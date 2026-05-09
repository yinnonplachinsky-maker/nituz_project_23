using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nituz_project_23
{
    public class TimeSlot
    {

        private DateTime startingDT;
        private DateTime endingDT;
        private TimeSlotStatus status;
        private ServiceCall serviceCall;

        public TimeSlot(DateTime startingDT,
            DateTime endingDT, TimeSlotStatus status, ServiceCall serviceCall, Boolean isNew) {

            this.startingDT = startingDT;
            this.endingDT = endingDT;
            this.status = status;
            this.serviceCall = serviceCall;

            if (isNew == true)
            {
                this.createTimeSlot();
                Program.timeslots.Add(this);
            }
        }

        public void UpdatePendingInDB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_update_timeslot_to_pending @startingDT, @endingDT";

            c.Parameters.AddWithValue("@startingDT", this.startingDT);
            c.Parameters.AddWithValue("@endingDT", this.endingDT);

            SQL_CON sc = new SQL_CON();
            sc.execute_non_query(c);
        }

        public void createTimeSlot()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_timeslot @startingDT, @endingDT, @status, @serviceCall";
            c.Parameters.AddWithValue("@startingDT", this.startingDT.ToString());
            c.Parameters.AddWithValue("@endingDT", this.endingDT);
            c.Parameters.AddWithValue("@status", this.status);
            c.Parameters.AddWithValue("@serviceCall", this.serviceCall.ToString());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public (DateTime startingDT, DateTime endingDT) GetTimeSlot()
        {
            return (this.startingDT, this.endingDT);
        }
        public override string ToString()
        {
            // מחזיר את שעת ההתחלה ושעת הסיום 
            return $"{this.startingDT.ToString("dd/MM HH:mm")} - {this.endingDT.ToString("HH:mm")}";
        }

            public DateTime getStartingDT()
        {
            return this.startingDT;
        }

        public DateTime getEndingDT()
        {
            return this.endingDT;
        }

        public TimeSlotStatus getStatus()
        {
            return this.status;
        }

        public void setStatus(TimeSlotStatus newStatus)
        {
            this.status = newStatus;
        }
    }
}
