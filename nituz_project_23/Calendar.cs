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
    public partial class Calendar : Form
    {
        public static DateTime selectedDate;

        public Calendar()
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

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerLandingPage customerLandingPage = new CustomerLandingPage();
            customerLandingPage.Show();
            this.Close();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            Program.SelectedDate = e.Start.Date;
            DateTime selected = monthCalendar1.SelectionStart; // התאריך שהמשתמש בחר

            // בדיקה מהירה: האם יש בכלל תורים פנויים בתאריך הזה?
            bool hasSlots = Program.timeslots.Any(ts =>
                                ts.getStatus() == TimeSlotStatus.Available &&
                                ts.getStartingDT().Date == selected.Date);

            if (!hasSlots)
            {
                MessageBox.Show("No available slots for the selected date.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // עוצרים כאן! לא פותחים את החלון הבא
            }

            else
            {
                TimeSlotPicker timeSlotPicker = new TimeSlotPicker();
                timeSlotPicker.Show();
                this.Close();
            }

        }

        private void Calendar_Load(object sender, EventArgs e){}
        private void Calendar_FormClosed(object sender, FormClosedEventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e){}
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e){}
    }
}
