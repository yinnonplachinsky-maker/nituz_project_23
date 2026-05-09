using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nituz_project_23
{
    public partial class TimeSlotPicker : Form
    {
        public TimeSlotPicker()
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

            LoadAvailableTimeSlots(Program.SelectedDate);
        }

        private void LoadAvailableTimeSlots(DateTime selectedDate)
        {

            // סינון התורים: רק כאלה שהם פנויים ושהתאריך שלהם זהה בדיוק לתאריך שנבחר
            List<TimeSlot> relevantSlots = Program.timeslots
                .Where(ts =>
                    ts.getStatus() == TimeSlotStatus.Available &&
                    ts.getStartingDT().Date == selectedDate.Date) // השוואה של התאריך בלבד
                .OrderBy(ts => ts.getStartingDT())
                .ToList();

            if (relevantSlots.Count == 0)
            {
                MessageBox.Show("No available slots for the selected date.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // הגדרות הקומבובוקס
            TSP_TimeSlotCombo.DataSource = null; // ניקוי קודם למניעת באגים
            TSP_TimeSlotCombo.DataSource = relevantSlots;
        }


        private void TSP_BackButton_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Close();
        }

        private void TSPScheduleButton_Click(object sender, EventArgs e)
        {
            if (TSP_TimeSlotCombo.SelectedItem == null)
            {
                MessageBox.Show("Choose a time slot");
                return;
            }

            TimeSlot chosen = (TimeSlot)TSP_TimeSlotCombo.SelectedItem;

            var result = MessageBox.Show($"Confirm booking for {chosen.getStartingDT()} - {chosen.getEndingDT()}?",
                             "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    chosen.setStatus(TimeSlotStatus.Pending);
                    chosen.UpdatePendingInDB();

                    MessageBox.Show("Job Scheduled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Calendar calendar = new Calendar();
                    calendar.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    // אם משהו השתבש (למשל אין חיבור ל-DB), נחזיר את הסטטוס לקודם
                    chosen.setStatus(TimeSlotStatus.Available);
                    MessageBox.Show("Error updating Database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void TimeSlotPicker_Load(object sender, EventArgs e){}

        private void TimeSlotPicker_FormClosed(object sender, FormClosedEventArgs e){}
        private void TSP_TimeSlotCombo_SelectedIndexChanged(object sender, EventArgs e){}
    }
}
