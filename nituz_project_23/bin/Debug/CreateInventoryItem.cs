using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nituz_project_23
{
    public partial class CreateInventoryItem : Form
    {
        public CreateInventoryItem()
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
            // מילוי הקומבובוקס בערכים מהאינומרטור המתאים
            CIICategoryItemList.DataSource = Enum.GetValues(typeof(ItemCategory));
        }

        private void CIIMaximumQuantity_Leave(object sender, EventArgs e)
        {
            // ניסיון המרה של שלושת השדות למספרים שלמים
            bool isQuantityValid = int.TryParse(CIIQuantity.Text, out int quantity);
            bool isMinValid = int.TryParse(CIIMinimunQuantity.Text, out int min);
            bool isMaxValid = int.TryParse(CIIMaximumQuantity.Text, out int max);

            // בדיקה האם כל השדות הם אכן מספרים שלמים
            if (!isQuantityValid || !isMinValid || !isMaxValid)
            {
                MessageBox.Show("Please enter only whole numbers in the quantity fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // החזרת הפוקוס לתיבה כדי שהמשתמש יתקן
                CIIMaximumQuantity.Focus(); 
                return;
            }

            // בדיקה שהמקסימום גדול מהמינימום
            if (max <= min)
            {
                MessageBox.Show("Maximum quantity must be greater than minimum quantity.", "Logical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // ניקוי הערך השגוי או סימונו
                CIIMaximumQuantity.SelectAll();
                CIIMaximumQuantity.Focus();
            }
        }

        private void CIICreateButton_Click(object sender, EventArgs e)
        {
            // אם לא מולאו חלק משדות החובה
            if (string.IsNullOrWhiteSpace(CIIName.Text) ||
                string.IsNullOrWhiteSpace(CIICategoryItemList.Text) ||
                string.IsNullOrWhiteSpace(CIIQuantity.Text) ||
                string.IsNullOrWhiteSpace(CIIMinimunQuantity.Text) || string.IsNullOrWhiteSpace(CIIMaximumQuantity.Text))
            {
                // הצג את ההודעה הבאה
                MessageBox.Show(
                    "Please fill all 5 first fields.",
                    // כותרת ההודעה
                    "Validation",
                    // כפתור "אוקי" לנעול את שאר הכפתורים עד לסיום המשתמש
                    MessageBoxButtons.OK,
                    // אייקון ההודעה הוא "אזהרה"
                    MessageBoxIcon.Warning
                );
                return;
            }

            bool isDuplicate = Program.inventoryItems.Any(item =>
            item.getName().Trim().Equals(CIIName.Text.Trim(), StringComparison.OrdinalIgnoreCase));

            if (isDuplicate)
            {
                MessageBox.Show(
                    $"The item '{CIIName.Text.Trim()}' already exists in the database.",
                    "Duplicate Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                CIIName.Focus(); // מחזיר את הסמן לשדה השם
                CIIName.SelectAll(); // מסמן את הטקסט כדי שיהיה קל למחוק
                return; // עוצר את הפונקציה ולא ממשיך ליצירת הפריט
            }

            // יצירת אובייקט פריט מלאי חדש אשר גם מוסיפה אותו בדאטא בייס
            InventoryItem newItem = new InventoryItem(Program.getNextInventoryItemID(), CIIName.Text,
                (ItemCategory)Enum.Parse(typeof(ItemCategory), CIICategoryItemList.Text), int.Parse(CIIQuantity.Text),
                int.Parse(CIIMaximumQuantity.Text), int.Parse(CIIMinimunQuantity.Text), CIIDescription.Text, true);


            this.ClearFormFields();

        }
        private void ClearFormFields()
        {
            CIIName.Text = "";
            CIICategoryItemList.SelectedIndex = -1;
            CIIQuantity.Text = "";
            CIIMinimunQuantity.Text = "";
            CIIMaximumQuantity.Text = "";
            CIIDescription.Text = "";
        }

        private void go_back_button_Click_1(object sender, EventArgs e)
        {
            CrudInventoryItemMenu crudScreen = new CrudInventoryItemMenu();
            crudScreen.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e){}
        private void label4_Click(object sender, EventArgs e){}
        private void label9_Click(object sender, EventArgs e){}
        private void label3_Click(object sender, EventArgs e){}
        private void label2_Click(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private void go_back_button_Click(object sender, EventArgs e){}
        private void CreateInventoryItem_FormClosed(object sender, FormClosedEventArgs e){}
        private void label6_Click(object sender, EventArgs e){}
        private void label7_Click(object sender, EventArgs e){}
        private void CIIName_TextChanged(object sender, EventArgs e){}
        private void CIICategoryItemList_SelectedIndexChanged(object sender, EventArgs e){}
        private void CIIQuantity_TextChanged(object sender, EventArgs e){}
        private void CIIMinimunQuantity_TextChanged(object sender, EventArgs e){}
        private void CIIMaximumQuantity_TextChanged(object sender, EventArgs e){}
        private void CIIDescription_TextChanged(object sender, EventArgs e){}
        private void label6_Click_1(object sender, EventArgs e){}
        private void CreateInventoryItem_Load(object sender, EventArgs e){}
    }
}
