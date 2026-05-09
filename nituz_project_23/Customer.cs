using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nituz_project_23
{
    public class Customer
    {
        private int customerID;
        private string name;
        private string mainAddress;
        private string phoneNumber;
        private string eMail;
        private List<ServiceCall> serviceCalls = new List<ServiceCall>();
        private List<Review> reviews = new List<Review>();
       
        public Customer(int customerID, string name, string mainAddress,
            string phoneNumber, string eMail) { 
        
            this.customerID = customerID;
            this.name = name;
            this.mainAddress = mainAddress;
            this.phoneNumber = phoneNumber;
            this.eMail = eMail;
        }

        public string getName()
        {
            return this.name;
        }

        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public int getCustomerID()
        {
            return this.customerID;
        }

    }

}
