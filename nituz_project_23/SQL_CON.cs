using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient; //חשוב!
using System.Windows.Forms; //עבור ההודעות!
using System.Data;

namespace nituz_project_23
{
    class SQL_CON
    {
        SqlConnection conn;
        public SQL_CON()
        {
            conn = new SqlConnection("Data Source=IEMDBS;Initial Catalog=SAD_23;Integrated Security=True");
        }

        public int execute_non_query(SqlCommand cmd)
        {

            int rowsAffected = 0; // משתנה שיחזיק את מספר השורות שהושפעו

            try
            {
                // open a connection object
                this.conn.Open();
                cmd.Connection = conn;
                rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show(" השאילתה בוצעה בהצלחה", "המשך", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
                return -1; // נחזיר -1 כדי לסמן שהייתה שגיאה 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return rowsAffected;
        }
        public SqlDataReader execute_query(SqlCommand cmd)
        {
            try
            {
                // open a connection object
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader READER = cmd.ExecuteReader();
                return READER;
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
                return null;
            }


        }

    }

}