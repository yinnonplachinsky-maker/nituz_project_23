using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nituz_project_23
{
    public class Review
    {

        private int reviewID;
        private string title;
        private string description;
        private int rate;
        private Customer customer;
        private ServiceCall serviceCall;
       
        public Review(int reviewID, string title, string description, int rate, Customer customer, ServiceCall serviceCall, Boolean isNEW) { 
        
            this.reviewID = reviewID;
            this.title = title;
            this.description = description;
            this.rate = rate;
            this.customer = customer;
            this.serviceCall = serviceCall;
            
            if (isNEW == true)
            {
                this.createReview();
                Program.reviews.Add(this);
            }
        }

        // שיטה שמפעילה פרוצדורה שיוצרת בבסיס נתונים ביקורת חדשה 
        public void createReview()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_review @reviewID, @title, @description, @rate, @customerID, @serviceCallID";
            c.Parameters.AddWithValue("@reviewID", this.getReviewID());
            if (this.title != null) {
                c.Parameters.AddWithValue("title", this.title);
            }
            else { c.Parameters.AddWithValue("title", DBNull.Value); 
            }
            if (this.description != null)
            {
                c.Parameters.AddWithValue("@description", this.description);
            }
            else { c.Parameters.AddWithValue("@description", DBNull.Value);
            }
            c.Parameters.AddWithValue("@rate", this.getReviewRate());
            c.Parameters.AddWithValue("@customerID", this.customer.getCustomerID());
            if (this.serviceCall != null)
                c.Parameters.AddWithValue("@serviceCallID", this.serviceCall.getServiceCallID());
            else
                c.Parameters.AddWithValue("@serviceCallID", DBNull.Value); // שולח NULL ל-SQL
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // שיטה שמפעילה פרוצדורה שמעדכנת בבסיס נתונים את הביקורת אם קיימת
        public void updateReview()
        {
            try
            {
                SqlCommand c = new SqlCommand();

                // הגדרת שם הפרוצדורה בלבד
                c.CommandText = "SP_update_review";

                // שינוי סוג הפקודה לפרוצדורה שמורה
                c.CommandType = System.Data.CommandType.StoredProcedure;

                // הוספת הפרמטרים  
                c.Parameters.AddWithValue("@reviewID", this.reviewID);

                // טיפול ב-NULL 
                c.Parameters.AddWithValue("@title", (object)this.title ?? DBNull.Value);
                c.Parameters.AddWithValue("@description", (object)this.description ?? DBNull.Value);
                c.Parameters.AddWithValue("@rate", this.rate);

                SQL_CON SC = new SQL_CON();
                int rowsResult = SC.execute_non_query(c);

                if (rowsResult <= 0)
                {
                    MessageBox.Show("לא נמצאה ביקורת עם מזהה " + this.reviewID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בעדכון: " + ex.Message);
            }
        }

        // קבלת המזהה של הביקורת
        public int getReviewID()
        {
            return this.reviewID;
        }

        // קבלת דירוג הביקורת
        public int getReviewRate()
        {
            return this.rate;
        }

        // קבלת הלקוח של הביקורת
        public Customer getCustomer()
        {
            return this.customer;
        }

        // קבלת קריאת השירות של הביקורת
        public ServiceCall getServiceCall()
        {
            return this.serviceCall;
        }

        // קבלת כותרת הביקורת
        public string getTitle()
        {
            return this.title;
        }

        // קבלת תיאור הביקורת
        public string getDescription()
        {
            return this.description;
        }

        // שינוי כותרת הביקורת
        public void setTitle(string title) 
        { 
            this.title = title;
        }

        // שינוי תיאור הביקורת
        public void setDescription(string desc) 
        {
            this.description = desc; 
        }

        // שינוי דירוג הביקורת
        public void setReviewRate(int rate) 
        {
            this.rate = rate; 
        }

        // שיטה שקובעת מה קריאת השירות של הביקורת
        public void setServiceCall(ServiceCall sc)
        {
            this.serviceCall = sc;
        }


    }
}
