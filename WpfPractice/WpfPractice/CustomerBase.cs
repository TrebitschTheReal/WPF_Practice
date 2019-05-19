using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice
{
    class CustomerBase
    {
        private List<Customer> allCustomers = new List<Customer>();

        public CustomerBase()
        {

        }

        public List<Customer> AllCustomers
        {
            get { return allCustomers; }
        }
        public void GenerateCustomerList(Customer customer)
        {
            allCustomers.Add(customer);
            
        }
    }
}
