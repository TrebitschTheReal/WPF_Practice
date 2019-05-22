using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfPractice
{
    class CustomerBase
    {
        private ObservableCollection<Customer> allCustomers = new ObservableCollection<Customer>();

        public CustomerBase()
        {

        }

        public ObservableCollection<Customer> AllCustomers
        {
            get { return allCustomers; }
        }
        public void GenerateCustomerList(Customer customer)
        {
            allCustomers.Add(customer);
            
        }
    }
}
