using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_8_Task1
{
    internal class Person
    {
        private string name;
        private string address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void SetName(string name)
        { 
            this.name = name; 
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public string GetName()
        {
            return name;
        }
        public string GetAddress()
        {
            return address;
        }
        public string ToString()
        {
            string result = $"Person[name= {GetName()},address= {GetAddress()}]";
            return result;
        }
    }
}
