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
    public partial class CustomerLandingPage : Form
    {
        public CustomerLandingPage()
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
        }

        private void make_a_review_button_Click(object sender, EventArgs e)
        {
            WriteAReview reviewForm = new WriteAReview();
            reviewForm.Show();
            this.Close();
        }

        private void sign_out_button_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        private void CLP_ChooseTimeSlot_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Close();
        }

        private void CustomerLandingPage_FormClosed(object sender, FormClosedEventArgs e){}
        private void welcome_label_Click(object sender, EventArgs e){}
        private void CustomerLandingPage_Load(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
    }
}
