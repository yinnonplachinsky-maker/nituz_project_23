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
    public partial class OwnerLandingPage : Form
    {
        public OwnerLandingPage()
        {
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
            InitializeComponent();

        }

        private void sign_out_button_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void inventory_crud_Click(object sender, EventArgs e)
        {
            CrudInventoryItemMenu crudScreen = new CrudInventoryItemMenu();
            crudScreen.Show();
            this.Close();
        }

        private void selfEvaluation_button_Click(object sender, EventArgs e)
        {
            SubmitSelfEvaluation evaluationScreen = new SubmitSelfEvaluation();
            evaluationScreen.Show();
            this.Close();
        }

        private void OwnerLandingPage_Load(object sender, EventArgs e){}
        private void OwnerLandingPage_FormClosed(object sender, FormClosedEventArgs e){}
        private void welcome_label_Click(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
        private void label2_Click(object sender, EventArgs e){}
    }
}
