using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nituz_project_23
{
    public static class Program
    {

        public static List<InventoryItem> inventoryItems = new List<InventoryItem>();
        public static List<Review> reviews = new List<Review>();
        public static List<ServiceCall> serviceCalls = new List<ServiceCall>();
        public static List<Customer> customers = new List<Customer>();
        public static List<TimeSlot> timeslots = new List<TimeSlot>();
        public static DateTime SelectedDate;
        public static string CurrentUsername { get; set; } // המשתמש המחובר כרגע
        public static UserRole CurrentRole { get; set; } = UserRole.Guest;

        // תחילת הקוד
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();//אתחול כל הרשימות;
            Application.Run(new MyAppManager());
        }

        // פונקציה לאתחול הרשימות
        public static void initLists()
        {
            initCustomers();
            initInventoryItems();
            initReviews();
            initServiceCalls();
            setServiceCallForReviewsFromDB();
            initTimeSlots();
        }

        // פונקציה זו מאתחלת את רשימת פריטי המלאי על ידי שליפת נתונים ממסד הנתונים
        private static void initInventoryItems()
        {
            // יצירת אובייקט פקודה להרצת הפרוצדורה השמורה ב-SQL
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Inventory_Items";

            // התחברות לבסיס הנתונים וביצוע השאילתה (באמצעות מחלקת העזר)
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            // מעבר על כל שורה שחזרה מהדאטה-בייס עד לסיום התוצאות
            while (rdr.Read())
            {
                // המרת הערך בעמודה השלישית ל-Enum של קטגוריית פריט
                ItemCategory cat = (ItemCategory)Enum.Parse(typeof(ItemCategory), rdr.GetValue(2).ToString());

                // יצירת אובייקט פריט מלאי חדש ומיפוי הערכים מהטבלה לשדות המחלקה:
                InventoryItem newItem = new InventoryItem(
                    int.Parse(rdr.GetValue(0).ToString()),      // InventoryItemID
                    rdr.GetValue(1).ToString(),                 // Name
                    cat,                                        // Category (Enum)
                    int.Parse(rdr.GetValue(3).ToString()),      // Quantity
                    int.Parse(rdr.GetValue(4).ToString()),      // Max Quantity
                    int.Parse(rdr.GetValue(5).ToString()),      // Main Quantity
                    rdr.GetValue(6).ToString(),                 // Description
                    false                                       // IsNew , False default
                );

                inventoryItems.Add(newItem);  // הוספת הפריט שנוצר לרשימה

            }
        }

        // פונקציה לאתחול הביקורות
        private static void initReviews()
        {
            // יצירת אובייקט פקודה להרצת הפרוצדורה השמורה ב-SQL
            // התחברות לבסיס הנתונים וביצוע השאילתה (באמצעות מחלקת העזר)
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Reviews";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            // מעבר על כל שורה שחזרה מהדאטה-בייס עד לסיום התוצאות
            while (rdr.Read())
            {

                // יצירת אובייקט ביקורת חדש ומיפוי הערכים מהטבלה לשדות המחלקה
                Review newReview = new Review(int.Parse(rdr.GetValue(0).ToString()), // Review ID
                rdr.GetValue(1).ToString(), // Title
                rdr.GetValue(2).ToString(), // Description
                int.Parse(rdr.GetValue(3).ToString()), // Rate
                getCustomerByCustomerID(int.Parse(rdr.GetValue(4).ToString())), // Customer who wrote the review
                GetServiceCallByServiceCallID(int.Parse(rdr.GetValue(4).ToString())),
                false);

                reviews.Add(newReview); // הוספת הביקורת לרשימת הביקורות

            }
        }

        // פונקציה להשמת קריאות השירות לביקורות השונות לפי ה-DB
        public static void setServiceCallForReviewsFromDB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Reviews";
            SQL_CON SC = new SQL_CON();

            try
            {
                using (SqlDataReader rdr = SC.execute_query(c))
                {
                    while (rdr.Read())
                    {
                        // חילוץ ה-ID של הביקורת וה-ID של קריאת השירות מהשורה הנוכחית
                        int reviewID = int.Parse(rdr.GetValue(0).ToString());
                        int serviceCallID = int.Parse(rdr.IsDBNull(4) ? "0" : rdr.GetValue(4).ToString());

                        // חיפוש הביקורת הספציפית ברשימה שלנו (במקום לעבור על כולן כל פעם)
                        Review currentReview = reviews.FirstOrDefault(r => r.getReviewID() == reviewID);

                        if (currentReview != null)
                        {
                            if (serviceCallID == 0)
                            {
                                currentReview.setServiceCall(null);
                            }
                            else
                            {
                                // עדכון קריאת השירות לביקורת הספציפית שנמצאה
                                currentReview.setServiceCall(Program.GetServiceCallByServiceCallID(serviceCallID));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error mapping reviews: " + ex.Message);
            }
        }

        // פונקציה המאתחלת את רשימת קריאות השירות על ידי שליפתן ממסד הנתונים.
        private static void initServiceCalls()
        {
            // הגדרת פקודת ה-SQL להרצת הפרוצדורה השמורה שמחזירה את כל קריאות השירות
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Service_Calls";

            // יצירת חיבור וביצוע השאילתה מול בסיס הנתונים
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            // מעבר על תוצאות השאילתה שורה אחר שורה
            while (rdr.Read())
            {
                // המרת הערך מהעמודה באינדקס 2 ל-Enum של סטטוס קריאת השירות
                ServiceCallStatus status = (ServiceCallStatus)Enum.Parse(typeof(ServiceCallStatus), rdr.GetValue(2).ToString());

                // יצירת אובייקט קריאת שירות חדש (ServiceCall) ומיפוי הנתונים:
                ServiceCall newServiceCall = new ServiceCall(
                    int.Parse(rdr.GetValue(0).ToString()),                                // מזהה הקריאה (ID)
                    status,                                                              // status: הסטטוס שהומר
                    rdr.GetValue(5).ToString(),                                         // Evalution pros
                    rdr.GetValue(6).ToString(),                                        // Evalution con
                    int.Parse(rdr.IsDBNull(8) ? "0" : rdr.GetValue(8).ToString()),    // Review ID, Default 0 if Null
                    rdr.GetValue(3).ToString(),                                       // Address
                    int.Parse(rdr.GetValue(7).ToString()),
                    false                                                            // Is New
                );
                // הוספת קריאת השירות החדשה לרשימה 
                serviceCalls.Add(newServiceCall);
            }
        }

        // פונקציה לאתחול חלונות הזמן
        private static void initTimeSlots()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_TimeSlots";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                TimeSlotStatus status = (TimeSlotStatus)Enum.Parse(typeof(TimeSlotStatus), rdr.GetValue(4).ToString());

                TimeSlot newTimeSlot = new TimeSlot(
                                       DateTime.Parse(rdr.GetValue(0).ToString()),                                // Starting DT
                                       DateTime.Parse(rdr.GetValue(1).ToString()),                               // Ending DT
                                       status,                                                                  // Status
                                       serviceCalls.ElementAtOrDefault(int.Parse(rdr.IsDBNull(3) ? "0" : rdr.GetValue(3).ToString())), //Service Call
                                       false // Is new
                                       );

                timeslots.Add(newTimeSlot); // הוספת חלון הזמן החדש לרשימה 
            }

        }
        // פונקציה לאתחול הלקוחות
        private static void initCustomers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Customers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            while (rdr.Read())
            {
                // יצירת אובייקט לקוח חדש מהנתונים ב-Reader
                Customer cust = new Customer(
                    int.Parse(rdr.GetValue(0).ToString()),                                   // Customer ID
                    rdr.GetValue(1).ToString(),                                             // Name
                    rdr.GetValue(2).ToString(),                                            // Main Address
                    rdr.GetValue(3).ToString(),                                           // Phone Number
                    rdr.IsDBNull(4) ? "No Email" : rdr.GetValue(4).ToString()            // Email
                );
                customers.Add(cust); // הוספת הלקוח לרשימת הלקוחות
            }
        }

        // פונקציה לבדיקה אם מישהו מחובר
        public static bool IsLoggedIn()
        {
            return CurrentRole != UserRole.Guest;
        }

        // מנתקת את המשתמש הנוכחי מהמערכת על ידי איפוס השם והחזרת ההרשאות לרמת "אורח".
        public static void Logout()
        {
            CurrentUsername = null; // איפוס שם המשתמש
            CurrentRole = UserRole.Guest; // שינוי התפקיד לברירת מחדל (אורח)
        }

        // מחפשת ברשימת קריאות השירות קריאה ספציפית לפי מספר ה-ID שלה.
        public static ServiceCall findServiceCallByID(int id)
        {
            return serviceCalls.Find(x => x.getServiceCallID() == id);
        }

        // מחשבת מה צריך להיות ה-ID של פריט המלאי הבא שייווצר.
        public static int getNextInventoryItemID()
        {
            return inventoryItems[inventoryItems.Count - 1].getInventoryItemID() + 1;
        }

        // מחפשת פריט במלאי על פי השם המדויק שלו.
        public static InventoryItem findInventoryItemByName(string name)
        {
            return inventoryItems.FirstOrDefault(x => x.getName() == name);
        }

        // מחשבת את ה-ID הבא עבור ביקורת (Review) חדשה.
        public static int getNextReviewID()
        {
            return reviews[reviews.Count - 1].getReviewID() + 1;
        }

        // בודקת האם לקוח כבר רשום במערכת לפי שילוב של שם ומספר טלפון.
        public static bool isCustomerExist(string name, string phoneNumber)
        {
            return Program.customers.Any(x => x.getName() == name && x.getPhoneNumber() == phoneNumber);
        }

        // פונקציה שמחזירה לקוח לפי השם שלו
        public static Customer GetCustomerByCustomerName(string name)
        {

            for (int i = 0; i < Program.customers.Count; i++)
            {

                if (customers[i].getName() == name) 
                    return customers[i];

            }
            return null;
        }

        // פונקציה שמחזירה ביקורת מרשימת הביקורות לפי מספר ביקורת
        public static Review findReviewByReviewID (int reviewID)
        {

            foreach (Review r in reviews)
            {
                if (r.getReviewID() == reviewID) return r;
            }

            return null;
        }

        // פונקציה שמחזירה לקוח לפי המזהה שלו
        public static Customer getCustomerByCustomerID(int customerID)
        {
            foreach (Customer c in customers)
            {
                if (c.getCustomerID() == customerID) return c;
            }
            return null;
        }

        // פונקציה שמחזירה קריאת שירות לפי המזהה שלה
        private static ServiceCall GetServiceCallByServiceCallID(int serviceCallID)
        {
            foreach (ServiceCall sc in serviceCalls)

            {
                if (sc.getServiceCallID() == serviceCallID) { return sc; }

            }

            return null; // ערך ברירת מחדל אם לא נמצא
        }


    }
}
