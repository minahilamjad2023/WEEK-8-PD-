using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_8_Task1
{
    internal class Staff:Person
    {
        private string School;
        private double Pay;
        public Staff(string school, double pay,string name,string address):base(name,address)
        {
            School = school;
            Pay = pay;
            this.SetName(name);
            this.SetAddress(address);
        }
        public void SetSchool(string school)
        { 
            this.School = school;
        }
        public void SetPay(double pay)
        {
            this.Pay = pay;
        }
        public string GetSchool()
        {
            return this.School;
        }
        public double GetPay()
        {
             return Pay;
        }
        public new string ToString()
        {
            string result= $"Staff[{base.ToString()},School= {GetSchool()} Pay= {GetPay()}]";
            return result;
        }
    }
}
