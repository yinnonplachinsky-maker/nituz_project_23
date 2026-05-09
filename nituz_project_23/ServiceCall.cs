using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nituz_project_23
{
    public class ServiceCall
    {

        private ServiceCallStatus status;
        private int serviceCallID;
        private string evaluationPros;
        private string evaluationCons;
        private Review review;
        private object inventoryItemID;
        private string address;
        private Customer customer;
        public int ServiceCallID => this.getServiceCallID();
        public string DisplayInfo
        {
            get
            {
                return $"{ServiceCallID} | {address} ({status})";
            }
        }

        public ServiceCall(int serviceCallID, ServiceCallStatus status,
        string evaluationPros, string evaluationCons, int reviewID, string address, int customerID, Boolean isNew) 
        {

            this.serviceCallID = serviceCallID;
            this.status = status;
            this.evaluationCons = evaluationCons;
            this.evaluationPros = evaluationPros;
            this.review = Program.findReviewByReviewID(reviewID);
            this.address = address;
            this.customer = Program.getCustomerByCustomerID(customerID);

        }

        public void updateSelfEvaluation(string evaluationPros, string evaluationCons)
        {
            this.evaluationPros = evaluationPros;
            this.evaluationCons = evaluationCons;
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_update_self_evaluation @serviceCallID, @evaluationPros, @evaluationCons";
            c.Parameters.AddWithValue("@serviceCallID", this.serviceCallID.ToString());
            c.Parameters.AddWithValue("@evaluationPros", this.evaluationPros);
            c.Parameters.AddWithValue("@evaluationCons", this.evaluationCons);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public string getEvaluationCons()
        {
            return this.evaluationCons;
        }

        public string getEvaluationPros()
        {
            return this.evaluationPros;
        }

        public int getServiceCallID()
        {

            return this.serviceCallID;
        }

        public ServiceCallStatus getServiceCallStatus()
        {
            return this.status;
        }

        public int getCustomerID ()
        {
            return this.customer.getCustomerID();
        }

        public void setReview(Review review)
        {
            this.review = review;
        }

    }
}
