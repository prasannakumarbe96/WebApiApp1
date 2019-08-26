using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiApp.Models
{
    interface ICustomer
    {
        bool AddCust(Customer customer);
        bool DeleteCust(int custId);
        bool UpdateCust(int custId, Customer customer);
        Customer GetCustById(int custId);
        IEnumerable<Customer> GetAllCust();
    }
}
