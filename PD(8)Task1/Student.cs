using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_8_Task1
{
    internal class Student:Person
    {
        private string Program;
        private int Year;
        private double Fee;
        public Student(string Program, int Year,double fee,string name,string address):base(name,address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = fee;
            this.SetName(name);
            this.SetAddress(address);
        }
        public void SetProgram(string Program)
        { 
            this.Program = Program;
        }
        public string GetProgram()
        {
            return this.Program;
        }
        public int GetYear()
        {
            return this.Year;
        }
        public double GetFee()
        {
            return this.Fee;
        }
        public void SetFee(double fee)
        {
            this.Fee = fee;
        }
        public void SetYear(int year)
        {
            this.Year = year;
        }
        public new string ToString()
        {
            string result=$"Student[{base.ToString()},Program= {GetProgram()},Year= {GetYear()},Fee= {GetFee()}]";
            return result;
        }
    } 
}
