using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice
{
    class Customer
    {
        private string name = "";
        private int age = 0;
        private string adress = "";
        private int sex = 0;

        public Customer(string name, int age, string adress)
        {
            this.name = name;
            this.age = age;
            this.adress = adress;
        }
        public string Name
        {
            get { return name; }
            //set { name = value; }
        }
        public int Age
        {
            get { return age; }
        }
        public string Adress
        {
            get { return adress; }
        }
    }
}
