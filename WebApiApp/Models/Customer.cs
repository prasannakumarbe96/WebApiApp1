using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiApp.Models
{
    public class Customer : ICustomer
    {
        public static List<Customer> listOfCustomers = new List<Customer>();
        private int CustId { get; set; }
        private string CustName { get; set; }
        private string CustDOB { get; set; }
        private string CustGender { get; set; }

        public bool AddCust(Customer customer)
        {
            var temp = false;
            IEnumerable<Customer> list = Customer.listOfCustomers;
            IEnumerator<Customer> allcustlist = list.GetEnumerator();
            while (allcustlist.MoveNext())
            {
                if (customer.CustId == allcustlist.Current.CustId)
                {
                    temp = true;
                    break;
                }
            }
            if(!temp)
            {
                Customer.listOfCustomers.Add(customer);
                return true;
            }
            else
            {
                return false;
            }
          
        }

        public bool DeleteCust(int custId)
        {
            var temp = false;
            Customer delCust = null;
            IEnumerable<Customer> list = Customer.listOfCustomers;
            IEnumerator<Customer> allcustlist = list.GetEnumerator();
            while (allcustlist.MoveNext())
            {
                if (custId == allcustlist.Current.CustId)
                {
                    temp = true;
                    delCust = allcustlist.Current;
                    break;
                }
            }
            if (!temp && delCust!=null)
            {
                Customer.listOfCustomers.Remove(delCust);
                return true;
            }
            else
            {
                return false;
            }

        }

        public IEnumerable<Customer> GetAllCust()
        {
            return Customer.listOfCustomers;
        }

        public Customer GetCustById(int custId)
        {
            var temp = false;
            Customer delCust = null;
            IEnumerable<Customer> list = Customer.listOfCustomers;
            IEnumerator<Customer> allcustlist = list.GetEnumerator();
            while (allcustlist.MoveNext())
            {
                if (custId == allcustlist.Current.CustId)
                {
                    temp = true;
                    delCust = allcustlist.Current;
                    break;
                }
            }
            if (!temp && delCust != null)
            {
        
                return delCust;
            }
            else
            {
                return delCust;
            }

        }

        public bool UpdateCust(int custId, Customer customer)
        {

            var temp = false;
            Customer delCust = null;
            IEnumerable<Customer> list = Customer.listOfCustomers;
            IEnumerator<Customer> allcustlist = list.GetEnumerator();
            while (allcustlist.MoveNext())
            {
                if (custId == allcustlist.Current.CustId)
                {
                    temp = true;
                    delCust = allcustlist.Current;
                    break;
                }
            }
            if (!temp && delCust != null)
            {
                Customer.listOfCustomers[Customer.listOfCustomers.IndexOf(delCust)]= customer;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}