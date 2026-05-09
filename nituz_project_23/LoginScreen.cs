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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();

            // הגדרת רמז ראשוני לשם משתמש
            NameLogin_textbox.Text = "Enter Username...";
            NameLogin_textbox.ForeColor = Color.Silver;

            // הגדרת רמז ראשוני לטלפון
            PhoneTextBox.Text = "Enter Phone Number...";
            PhoneTextBox.ForeColor = Color.Silver;

            // ווידוא שבתחילת הטופס המשתמש לא מחובר
            Program.CurrentUsername = "";
            Program.CurrentRole = UserRole.Guest;
        }

        private void NameLoginButton_Enter(object sender, EventArgs e)
        {

            if (NameLogin_textbox.Text == "Enter Username...") {
                NameLogin_textbox.Text = "";       // מוחק את הרמז
                NameLogin_textbox.ForeColor = Color.Black; // מחזיר את הצבע לשחור
            }

        }

        private void NameLoginButton_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(NameLogin_textbox.Text))
            {
                NameLogin_textbox.Text = "Enter Username..."; // מחזיר את הרמז
                NameLogin_textbox.ForeColor = Color.Silver;    // הופך אותו לאפור שוב
            }

        }

        private void IDNumberOrPhoneTextBox_Enter(object sender, EventArgs e)
        {

            if (PhoneTextBox.Text == "Enter Phone Number...")
            {
                PhoneTextBox.Text = "";       // מוחק את הרמז
                PhoneTextBox.ForeColor = Color.Black; // מחזיר את הצבע לשחור
            }

        }

        private void IDNumberOrPhoneTextBox_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {
                PhoneTextBox.Text = "Enter Phone Number..."; // מחזיר את הרמז
                PhoneTextBox.ForeColor = Color.Silver;    // הופך אותו לאפור שוב
            }

        }

        private void login_button_Click(object sender, EventArgs e)
        {

            // אם לא מולאו השדות
            if (string.IsNullOrWhiteSpace(NameLogin_textbox.Text) ||
                string.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userName = NameLogin_textbox.Text;
            string Phone = PhoneTextBox.Text;
 
            // במידה וזה שחר - מנהל העסק
            if (userName == "Shahar" && Phone == "206505414")
            {
                Program.CurrentUsername = userName;
                Program.CurrentRole = UserRole.Admin;

                // מעבר לטופס הבא
                OwnerLandingPage ownerForm = new OwnerLandingPage();
                ownerForm.Show();
                this.Close();
                return;
            }

            else
            {
                if (Program.isCustomerExist(userName, Phone))
                {
                    Program.CurrentUsername = userName;
                    Program.CurrentRole = UserRole.Customer;

                    // מעבר לטופס הבא
                    CustomerLandingPage customerForm = new CustomerLandingPage();
                    customerForm.Show();
                    this.Close();
                    return;
                }
            }

            // במידה ואין לקוח כזה במערכת
            MessageBox.Show("There is no registered customer with that name/phone number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void SignInWithGoogleButton_Click(object sender, EventArgs e)
        {
            // הצגת תיבת הודעה למשתמש
            MessageBox.Show("Sorry, signing via Google Account is not available at the moment", "Google Sign-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void enter_phoneNumber_Click(object sender, EventArgs e){}
        private void NameLogin_textbox_TextChanged_1(object sender, EventArgs e){}
        private void IDNumberOrPhoneTextBox_TextChanged(object sender, EventArgs e){}
        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e){}
        private void NameLogin_textbox_TextChanged(object sender, EventArgs e){}
        private void LoginScreen_Load(object sender, EventArgs e){}
        private void pictureBox1_Click(object sender, EventArgs e){}
        private void pictureBox1_Click_1(object sender, EventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void IDNumberOrPhoneTextBox_TextChanged_1(object sender, EventArgs e){}

    }

 }
