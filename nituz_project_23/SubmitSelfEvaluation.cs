using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace nituz_project_23
{
    public partial class SubmitSelfEvaluation : Form
    {
        public SubmitSelfEvaluation()
        {
            InitializeComponent();


            // בדיקה אם המשתמש הוא מנהל
            if (Program.CurrentRole != UserRole.Admin)
            {
                MessageBox.Show("Access Denied. Admins only!", "Security",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop);

                // סגירת הטופס והחזרה לתפריט הראשי
                LoginScreen logInScreen = new LoginScreen();
                logInScreen.Show();
                this.Close();
            }


            // מילוי הקומבובוקס של קריאות השירות בערכים
            this.LoadServiceCallIDs();

            // לא לתת למשתמש לכתוב יתרונות וחסרונות וללחוץ על הכפתור לפני שבחר מספר קריאת שירות
            this.LockEvaluationFields();
        }

        public void LoadServiceCallIDs()
        {

            // ניתוק האירוע כדי שלא יקפוץ בזמן הגדרת הדאטה
            serviceCall_combo_box.SelectedIndexChanged -= serviceCall_combo_box_SelectedIndexChanged_1;

            // שליפת רשימת שמות הפריטים בלבד מתוך רשימת האובייקטים
            List<int> servicesIDs = Program.serviceCalls.Select(x => x.getServiceCallID()).ToList();

            // הגדרת מקור הנתונים של הקומבובוקס
            serviceCall_combo_box.DataSource = servicesIDs;

            // אפשור חיפוש אוטמטי
            serviceCall_combo_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            serviceCall_combo_box.AutoCompleteSource = AutoCompleteSource.ListItems;

            serviceCall_combo_box.SelectedIndex = -1;

            // חיבור מחדש של האירוע
            serviceCall_combo_box.SelectedIndexChanged += serviceCall_combo_box_SelectedIndexChanged_1;
        }

        // פונקציית הכפתור Submit
        private void SSESubmit_Click(object sender, EventArgs e)
        {

            // אם לא נבחר ערך בקומבובוקס
            if (serviceCall_combo_box.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service call.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // אם לא מולאו יתרונות וחסרונות
            if (string.IsNullOrWhiteSpace(SSEEvaluationPros.Text) &&
                string.IsNullOrWhiteSpace(SSEEvaluationCons.Text))
            {
                // הצג את ההודעה הבאה
                MessageBox.Show("Please fill at least one evaluation field (Pros or Cons).","Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // שליפת מספר קריאת השירות
            int id = int.Parse(serviceCall_combo_box.Text);

            // יצירת אובייקט קריאת שירות כדי להפעיל את השיטה
            ServiceCall sc = Program.findServiceCallByID(id);

            // הפעלת השיטה לעדכון הקריאת שירות והעברת היתרונות והחסרונות
            sc.updateSelfEvaluation(SSEEvaluationPros.Text,SSEEvaluationCons.Text);

            // הודעת הצלחה
            MessageBox.Show("Self evaluation submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // רענון הטופס
            this.ClearFormFields();
        }

        // שיטה לנעילת היתרונות, חסרונות, וכפתור ההגש
        private void LockEvaluationFields()
        {
            SSEEvaluationPros.Enabled = false;
            SSEEvaluationCons.Enabled = false;
            SSESubmit.Enabled = false;
        }

        private void UnlockEvaluationFields()
        {
            SSEEvaluationPros.Enabled = true;
            SSEEvaluationCons.Enabled = true;
            SSESubmit.Enabled = true;
        }

        private void serviceCall_combo_box_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (serviceCall_combo_box.SelectedIndex != -1)
            {
                this.UnlockEvaluationFields();

                try
                {
                    int id = int.Parse(serviceCall_combo_box.SelectedItem.ToString());
                    ServiceCall sc = Program.findServiceCallByID(id);

                    if (sc != null)
                    {

                        SSEEvaluationPros.Text = sc.getEvaluationPros();
                        SSEEvaluationCons.Text = sc.getEvaluationCons();

                        // בדיקה האם מדובר בעדכון או ביצירה חדשה
                        bool isUpdate = !string.IsNullOrEmpty(SSEEvaluationPros.Text) || !string.IsNullOrEmpty(SSEEvaluationCons.Text);

                        // החלפת התמונה והטקסט
                        UpdateSubmitButtonImage(isUpdate);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading evaluation: " + ex.Message);
                }
            }
            else
            {
                this.ClearFormFields(); // קריאה לשיטת הניקוי והנעילה
            }
        }

        private void ClearFormFields()
        {
            serviceCall_combo_box.SelectedIndex = -1;
            SSEEvaluationPros.Text = "";
            SSEEvaluationCons.Text = "";
            // איפוס לתמונת ההגשה המקורית
            UpdateSubmitButtonImage(false);
            this.LockEvaluationFields();
        }

        private void go_back_button_Click(object sender, EventArgs e)
        {
            OwnerLandingPage ownerForm = new OwnerLandingPage();
            ownerForm.Show();
            this.Close();
        }

        private void UpdateSubmitButtonImage(bool isUpdate)
        {
            
            string fileName = isUpdate ? "update self evaluation.png" : "self evaluation.png";
            string imagePath = Path.Combine(Application.StartupPath, "Images", fileName);

            if (File.Exists(imagePath))
            {
                SSESubmit.BackgroundImage = Image.FromFile(imagePath);
                SSESubmit.BackgroundImageLayout = ImageLayout.Stretch; // מונע את קפיצת הגודל
                SSESubmit.Text = ""; // מעלים את הטקסט כדי לראות את התמונה
            }
            else
            {
                // אם התמונה חסרה, נחזיר טקסט כדי שהכפתור לא יהיה ריק
                SSESubmit.BackgroundImage = null;
                SSESubmit.Text = isUpdate ? "Update Evaluation" : "Submit Evaluation";
            }
        }

        private void SubmitSelfEvaluation_FormClosed(object sender, FormClosedEventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private void SubmitSelfEvaluation_Load(object sender, EventArgs e){}
        private void serviceCall_combo_box_SelectedIndexChanged(object sender, EventArgs e){}
        private void SSEEvaluationPros_TextChanged(object sender, EventArgs e){}
        private void SSEEvaluationCons_TextChanged(object sender, EventArgs e){}

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


