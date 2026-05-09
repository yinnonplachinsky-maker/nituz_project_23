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
    public partial class CrudInventoryItemMenu : Form
    {
        public CrudInventoryItemMenu()
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetItemDetails detailsForm = new GetItemDetails();
            detailsForm.Show();
            this.Close();
        }

        private void CreateNewInventoryItem_Click(object sender, EventArgs e)
        {
            CreateInventoryItem createForm = new CreateInventoryItem();
            createForm.Show();
            this.Close();
        }

        private void go_back_button_Click(object sender, EventArgs e)
        {
            OwnerLandingPage ownerForm = new OwnerLandingPage();
            ownerForm.Show();
            this.Close();
        }

        private void CrudInventoryItemMenu_FormClosed(object sender, FormClosedEventArgs e){}
        private void Form2_Load(object sender, EventArgs e){}
        private void DeleteItemInventory_Click(object sender, EventArgs e){}

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
