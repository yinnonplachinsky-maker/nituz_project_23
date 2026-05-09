using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nituz_project_23
{

    public partial class WriteAReview : Form
    {

        private Review existingReviewLoaded = null; 

        public WriteAReview()
        {
            InitializeComponent();

            // בדיקה אם המשתמש מחובר כלקוח
            if (Program.CurrentRole != UserRole.Customer)
            {
                MessageBox.Show("Access Denied. Customers only!", "Security",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);

                // סגירת הטופס והחזרה לתפריט הראשי
                LoginScreen logInScreen = new LoginScreen();
                logInScreen.Show();
                this.Close();
            }

            // מילוי הקומבובוקס של קריאות השירות בערכים
            this.LoadServiceCallIDs();

            // מילוי הקומבובוקס בערכים 1 עד 5
            ratingComboBox.Items.Add(1);
            ratingComboBox.Items.Add(2);
            ratingComboBox.Items.Add(3);
            ratingComboBox.Items.Add(4);
            ratingComboBox.Items.Add(5);

            // הגדרת הקומבובוקס כך שהמשתמש לא יוכל לשנות ערכים בקומבובוקס
            ratingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void LoadServiceCallIDs()
        {
            try
            {
                Customer loggedInCustomer = Program.GetCustomerByCustomerName(Program.CurrentUsername);
                if (loggedInCustomer == null) return;

                int myID = loggedInCustomer.getCustomerID();

                var myCompletedCalls = Program.serviceCalls
                    .Where(sc => sc.getServiceCallStatus() == ServiceCallStatus.Completed
                              && sc.getCustomerID() == myID)
                    .ToList();

                // יצירת המקור לקומבובוקס עם האופציה הכללית
                var comboSource = myCompletedCalls.Select(sc => new {
                    ID = sc.getServiceCallID(),
                    Text = sc.DisplayInfo
                }).ToList();

                comboSource.Insert(0, new { ID = -1, Text = "-- ביקורת כללית (ללא קריאה) --" });

                // ניתוק זמני של האירוע כדי למנוע קפיצות מיותרות בזמן הטעינה
                serviceCall_combo_box.SelectedIndexChanged -= serviceCall_combo_box_SelectedIndexChanged;

                // הגדרות תצוגה
                serviceCall_combo_box.DataSource = comboSource;
                serviceCall_combo_box.DisplayMember = "Text"; // השם שנתת ב-comboSource
                serviceCall_combo_box.ValueMember = "ID";    // השם שנתת ב-comboSource

                // ברירת מחדל: הפריט הראשון (ביקורת כללית)
                serviceCall_combo_box.SelectedIndex = 0;

                // חיבור חזרה של האירוע
                serviceCall_combo_box.SelectedIndexChanged += serviceCall_combo_box_SelectedIndexChanged;

                // ניקוי ראשוני של הטופס
                LoadExistingReviewData(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading calls: " + ex.Message);
            }
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {

             try
             {

                // ולידציה של קלטים 
                if (!IsValidInput()) return;

                Customer loggedInCustomer = Program.GetCustomerByCustomerName(Program.CurrentUsername);

                bool userCanceled;
                ServiceCall sc = GetSelectedServiceCall(out userCanceled);
                if (userCanceled) return;

                //  בדיקה האם קיימת ביקורת קיימת וטיפול בה (עדכון)
                if (sc != null)
                {
                    Review existingReview = FindExistingReview(loggedInCustomer, sc);
                    if (existingReview != null)
                    {
                        HandleExistingReviewUpdate(existingReview);
                        return; // העדכון בוצע, אין צורך להמשיך ליצירת חדש
                    }
                }

                // יצירת ביקורת חדשה (אם הגענו לכאן)
                CreateAndSaveNewReview(loggedInCustomer, sc);
            }
            catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        // בדיקת קלטים בטופס כתיבת ביקורת
        private bool IsValidInput()
        {
            if (ratingComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a rating (1-5).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(title_text_box.Text))
            {
                MessageBox.Show("Please enter a title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                title_text_box.Focus();
                return false;
            }
            return true;
        }

        // החזרת קריאת השירות הרלוונטית או נאל אם ביקורת כללית
        private ServiceCall GetSelectedServiceCall(out bool userCanceled)
        {
            userCanceled = false;

            // בדיקה אם לא נבחר כלום או שנבחר הפריט הפיקטיבי של ביקורת כללית
            if (serviceCall_combo_box.SelectedValue == null || (int)serviceCall_combo_box.SelectedValue == -1)
            {
                DialogResult result = MessageBox.Show("No service call selected. Submit a general review instead?",
                                                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    userCanceled = true;
                    return null;
                }
                return null; // המשתמש אישר ביקורת כללית
            }

            // אם הגענו כאן, נבחרה קריאה אמיתית
            int selectedCallID = (int)serviceCall_combo_box.SelectedValue;
            return Program.findServiceCallByID(selectedCallID);
        }

        // עדכון ביקורת קיימת בזיכרון
        private void HandleExistingReviewUpdate(Review existingReview)
        {
            DialogResult result = MessageBox.Show("Review already exists. Update it?", "Existing Review",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                existingReview.setTitle(title_text_box.Text);
                existingReview.setDescription(description_text_box.Text);
                existingReview.setReviewRate(int.Parse(ratingComboBox.SelectedItem.ToString()));

                existingReview.updateReview();

                MessageBox.Show("Review updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearFormFields();
            }
        }

        // יצירת ביקורת 
        private void CreateAndSaveNewReview(Customer customer, ServiceCall sc)
        {
            Review newReview = new Review(
                Program.getNextReviewID(),
                title_text_box.Text,
                description_text_box.Text,
                int.Parse(ratingComboBox.SelectedItem.ToString()),
                customer,
                sc,
                true
            );

            if (sc != null)
            {
                sc.setReview(newReview);
            }

            MessageBox.Show("Review submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ClearFormFields();
        }

        // חיפוש ביקורת קיימת בזיכרון
        private Review FindExistingReview(Customer customer, ServiceCall sc)
        {
            if (sc == null || customer == null)
                return null;

            foreach (Review r in Program.reviews)
            {
                // תחנה 1: בדיקת אובייקט הלקוח בתוך הביקורת
                Customer reviewCust = r.getCustomer();
                if (reviewCust == null)
                {
                    // אם הגענו לכאן, יש ביקורת בזיכרון שלא מקושרת ללקוח
                    continue;
                }

                // תחנה 2: השוואת מזהה הלקוח
                bool isSameCustomer = (reviewCust.getCustomerID() == customer.getCustomerID());
                if (!isSameCustomer)
                {
                    continue; // לקוח אחר, עוברים לביקורת הבאה
                }

                // תחנה 3: בדיקת אובייקט קריאת השירות בתוך הביקורת
                ServiceCall reviewSC = r.getServiceCall();
                if (reviewSC == null)
                {
                    continue; // ביקורת כללית (בלי קריאה), לא מה שאנחנו מחפשים כרגע
                }

                // תחנה 4: השוואת מזהה קריאת השירות
                if (reviewSC.getServiceCallID() == sc.getServiceCallID())
                {
                    return r; // נמצאה התאמה
                }
            }

            return null; // לא נמצאה ביקורת תואמת
        }

        // טעינת נתוני ביקורת קיימת
        private void LoadExistingReviewData(Review r)
        {

            string submitFileName = "submit review.png";
            string updateFileName = "update review.png";

            // יצירת נתיב יחסי לתיקיית Images שבתוך תיקיית ההרצה
            string submitPath = Path.Combine(Application.StartupPath, "Images", submitFileName);
            string updatePath = Path.Combine(Application.StartupPath, "Images", updateFileName);

            ImageLayout layoutStyle = ImageLayout.Stretch;

            if (r != null)
            {

                // טעינת נתונים קיימים
                title_text_box.Text = r.getTitle();
                description_text_box.Text = r.getDescription();
                ratingComboBox.SelectedItem = r.getReviewRate();

                // טעינה מהתיקייה
                if (System.IO.File.Exists(updatePath))
                    Submit_button.BackgroundImage = Image.FromFile(updatePath);
                    Submit_button.BackgroundImageLayout = layoutStyle;

            }
            else
            {
                // אם אין ביקורת, ננקה את השדות לביקורת חדשה
                // ניקוי שדות הטקסט בלבד - בלי לגעת ב-ComboBox
                title_text_box.Clear();
                description_text_box.Clear();
                ratingComboBox.SelectedIndex = -1;

                if (System.IO.File.Exists(submitPath))
                    Submit_button.BackgroundImage = Image.FromFile(submitPath);
                    Submit_button.BackgroundImageLayout = layoutStyle;
            }
        }


        // טעינה של הביקורת הישנה ברגע שהמשתמש בוחר קריאת שירות
        private void serviceCall_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            existingReviewLoaded = null;

            // בדוק אם נבחר פריט והוא אינו הפריט הפיקטיבי (-1)
            if (serviceCall_combo_box.SelectedValue != null)
            {
                // חילוץ ה-ID (המרת אובייקט ל-int)
                int selectedID = (int)serviceCall_combo_box.SelectedValue;

                if (selectedID != -1)
                {
                    ServiceCall sc = Program.findServiceCallByID(selectedID);
                    Customer loggedInCustomer = Program.GetCustomerByCustomerName(Program.CurrentUsername);
                    existingReviewLoaded = FindExistingReview(loggedInCustomer, sc);
                    LoadExistingReviewData(existingReviewLoaded);
                }
            }

            LoadExistingReviewData(existingReviewLoaded);
        }

        // ניקוי הערכים מהטופס
        private void ClearFormFields()
        {
            serviceCall_combo_box.SelectedIndex = -1;
            ratingComboBox.SelectedIndex = -1;
            title_text_box.Text = "";
            description_text_box.Text = "";
        }

        private void go_back_button_Click(object sender, EventArgs e)
        {
            CustomerLandingPage customerForm = new CustomerLandingPage();
            customerForm.Show();
            this.Close();
        }

        private void WriteAReview_FormClosed(object sender, FormClosedEventArgs e){}
        private void description_Click(object sender, EventArgs e){}
        private void ratingComboBox_SelectedIndexChanged(object sender, EventArgs e){}
        private void ratingComboBox_SelectedIndexChanged_1(object sender, EventArgs e){}
        private void title_text_box_TextChanged(object sender, EventArgs e){}
        private void WriteAReview_Load(object sender, EventArgs e){}
        private void description_text_box_TextChanged(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
    }
}
