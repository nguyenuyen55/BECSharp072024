using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramwork.DO
{
    public class Student
    {
        int ID { get; set; }
        public string Name { get; set; }
        public double grade { get; set; }
      public  Student(int _id,string _name,double _grade) {
        this.ID = _id;
        this.Name = _name;
        this.grade = _grade;
        }
       
    }
}
