using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstConsoleApp1
{
     class Employee
    {
        private int id { get; set; }
        private string name { get; set; }
        private int age { get; set; }
        private Double sal {  get; set; }



        public Employee() { }

        public Employee(int id, string name, int age, Double sal) { 
            this.id = id;
            this.name = name;
            this.age = age;
            this.sal = sal;

        }


        //public override string ToString()
        //{
        //    return "ID "+id+"Name "+name+"Age "+age+"Salary "+sal;
        //}

        public override string ToString()
        {
            return string.Format("Id: {0}, Name: {1}, DeptNo: {2}, Salary: {3}", id, name, age, sal);
        }

    }
}
