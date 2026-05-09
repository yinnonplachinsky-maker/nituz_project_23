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
    public partial class GetItemDetails : Form
    {
        public GetItemDetails()
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
            GIDCategoryItemList.DataSource = Enum.GetValues(typeof(ItemCategory));

            // טעינת ערכי שמות הפריטים לתוך הקומבובוקס ואפשור חיפוש אוטומטי
            this.LoadItemNames();

            // ביטול הפקדים לפני חיפוש השם הרלוונטי
            this.DisableTools();
        }

        public void LoadItemNames()
        {
            // שליפת רשימת שמות הפריטים בלבד מתוך רשימת האובייקטים
            List<string> itemNames = Program.inventoryItems.Select(x => x.getName()).ToList();

            // הגדרת מקור הנתונים של הקומבובוקס
            GIDLookForItems.DataSource = itemNames;

            // אפשור חיפוש אוטמטי
            GIDLookForItems.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GIDLookForItems.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public void DisableTools()
        {
            GIDUpdateItemDetails.Enabled = false;
            GIDDeleteItemDetails.Enabled = false;
            GIDName.Enabled = false;
            GIDCategoryItemList.Enabled = false;
            GIDQuantity.Enabled = false;
            GIDMinimunQuantity.Enabled = false;
            GIDMaximumQuantity.Enabled = false;
            GIDDescription.Enabled = false;
        }

        public void EnableTools()
        {
            GIDUpdateItemDetails.Enabled = true;
            GIDDeleteItemDetails.Enabled = true;
            GIDName.Enabled = true;
            GIDCategoryItemList.Enabled = true;
            GIDQuantity.Enabled = true;
            GIDMinimunQuantity.Enabled = true;
            GIDMaximumQuantity.Enabled = true;
            GIDDescription.Enabled = true;
        }

        private void GIDLookForItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GIDLookForItems.SelectedItem == null)
            {
                return;
            }

            // השגת הפריט לפי השם שנבחר בקומבובוקס
            InventoryItem selectedItem = Program.findInventoryItemByName(GIDLookForItems.SelectedItem.ToString());

            // הכנסת שדות הפריט לתיבות הטקסט המתאימות
            if (selectedItem != null)
            {
                // אפשור שימוש בפקדים
                this.EnableTools();

                GIDName.Text = selectedItem.getName();
                GIDCategoryItemList.SelectedItem = selectedItem.getCategory();
                GIDQuantity.Text = selectedItem.getQuantity().ToString();
                GIDMinimunQuantity.Text = selectedItem.getMinQuantity().ToString();
                GIDMaximumQuantity.Text = selectedItem.getMaxQuantity().ToString();
                GIDDescription.Text = selectedItem.getDescription();
            }
        }

         private void GIDUpdateItemDetails_Click(object sender, EventArgs e)
        {
            string selectedName = GIDLookForItems.SelectedItem.ToString();
            InventoryItem selectedItem = Program.findInventoryItemByName(selectedName);

            // אם אין פריט כזה
            if (selectedItem == null)
            {
                MessageBox.Show("Please select a valid item to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // אם לא מולאו חלק משדות החובה
            if (string.IsNullOrWhiteSpace(GIDName.Text) ||
                string.IsNullOrWhiteSpace(GIDCategoryItemList.Text) ||
                string.IsNullOrWhiteSpace(GIDQuantity.Text) ||
                string.IsNullOrWhiteSpace(GIDMinimunQuantity.Text) ||
                string.IsNullOrWhiteSpace(GIDMaximumQuantity.Text)) 
            {
                MessageBox.Show("Please fill all 5 first fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // בדיקה האם כל השדות הם אכן מספרים שלמים
            bool isQuantityValid = int.TryParse(GIDQuantity.Text, out int quantity);
            bool isMinValid = int.TryParse(GIDMinimunQuantity.Text, out int min);
            bool isMaxValid = int.TryParse(GIDMaximumQuantity.Text, out int max);

            if (!isQuantityValid || !isMinValid || !isMaxValid)
            {
                MessageBox.Show("Please enter only whole numbers in the quantity fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // החזרת הפוקוס לתיבה כדי שהמשתמש יתקן
                GIDMaximumQuantity.Focus();
                return;
            }

            // בדיקה שהמקסימום גדול מהמינימום
            if (max <= min)
            {
                MessageBox.Show("Maximum quantity must be greater than minimum quantity.", "Logical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // ניקוי הערך השגוי או סימונו
                GIDMaximumQuantity.SelectAll();
                GIDMaximumQuantity.Focus();
            }

            // חילוץ הקטגוריה מהקומבובוקס
            ItemCategory selectedCategory = (ItemCategory)GIDCategoryItemList.SelectedItem;

            // קריאה לפונקציית העדכון בתוך מחלקת פריט מלאי
            selectedItem.updateInventoryItem(GIDName.Text, selectedCategory, quantity, max, min, GIDDescription.Text);

            // הודעת הצלחה ורענון
            MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadItemNames();
            ClearFormFields();

        }

        private void GIDDeleteItemDetails_Click(object sender, EventArgs e)
        {
            // השגת הפריט לפי השם שנבחר בקומבובוקס
            string selectedName = GIDLookForItems.SelectedItem.ToString();
            InventoryItem selectedItem = Program.findInventoryItemByName(selectedName);

            if (selectedItem != null)
            {
                // אישור מחיקה מול המשתמש
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedName}?",
                                                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // קריאה לפונקציית המחיקה למחיקה מהרשימה ומהדאטא בייס
                    selectedItem.deleteInventoryItem();

                    // הצגת הודעה, ניקוי השדות ורענון
                    MessageBox.Show("Item deleted successfully.");
                    LoadItemNames();
                    ClearFormFields();
                }
            }
        }

        private void ClearFormFields()
        {
            GIDLookForItems.SelectedIndex = -1;
            GIDName.Text = "";
            GIDCategoryItemList.SelectedIndex = -1;
            GIDQuantity.Text = "";
            GIDMinimunQuantity.Text = "";
            GIDMaximumQuantity.Text = "";
            GIDDescription.Text = "";
            this.DisableTools();
        }

        private void go_back_button_Click(object sender, EventArgs e)
        {
            CrudInventoryItemMenu crudScreen = new CrudInventoryItemMenu();
            crudScreen.Show();
            this.Close();
        }
        private void GetItemDetails_FormClosed(object sender, FormClosedEventArgs e){}
        private void GetItemDetails_Load(object sender, EventArgs e){}
        private void GIDName_TextChanged(object sender, EventArgs e){}
        private void GIDCategoryItemList_SelectedIndexChanged(object sender, EventArgs e){}
        private void GIDQuantity_TextChanged(object sender, EventArgs e){}
        private void GIDMinimunQuantity_TextChanged(object sender, EventArgs e){}
        private void GIDMaximumQuantity_TextChanged(object sender, EventArgs e){}
        private void GIDDescription_TextChanged(object sender, EventArgs e){}
    }
}
