using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace inheritance_demo2
{

    public class Customer
    {
        private string _name;
        private string _address;
        private string _mobileNumber;
        private int _age;

        public Customer()
        {

        }
        public Customer(string _name, string _address, string _mobileNumber, int _age)
        {
            this._name = _name;
            this._address = _address;
            this._mobileNumber = _mobileNumber;
            this._age = _age;
        }

        public string MobileNumber
        {
            get { return _mobileNumber; }
            set { _mobileNumber = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void DisplayCustomer()
        {
            Console.WriteLine("Bill Details\nName {0}\nMobile {1}\nAge {2}\nAddress {3}", _name, _mobileNumber, _age, _address);
        }
    }
}