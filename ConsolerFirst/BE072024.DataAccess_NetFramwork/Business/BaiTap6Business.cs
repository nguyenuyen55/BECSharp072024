using BE072024.DataAccess_NetFramwork.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAccess_NetFramwork.Business
{
    public class BaiTap6Business
    {
        public Dictionary<int, Student> initListStudent()
        {
            Dictionary<int, Student> listStudent = new Dictionary<int, Student>();
            listStudent.Add(1, new Student(1, "thu uyên", 8.0));
            listStudent.Add(2, new Student(2, "gia bảo", 9.0));
            listStudent.Add(3, new Student(3, "Ý như", 9.0));
            return listStudent;
        }
        public int countCaoHonTB(Dictionary<int, Student> arrayList){
            int count = 0;
            if (arrayList != null)
            {
            foreach(var student in arrayList)
                {
                    if (student.Value.grade > 5)
                    {
                        count++;
                    }
                }
            
            }
            return count;

            }
        public void FindStudentGradeHigh(Dictionary<int, Student> arrayList, double grade)
        {
            if (arrayList != null)
            {
                double swap = grade;
                if (grade>0)
                {
                    Console.WriteLine("Sinh viên có điểm cao hơn "+grade +":");
                    foreach (var student in arrayList)
                    {
                        if (swap < student.Value.grade)
                        {
                            Console.WriteLine(student.Value.Name + " Grade :" + student.Value.grade);
                        }
                    }

                }
                else
                {
                    foreach (var student in arrayList)
                    {
                        if (swap < student.Value.grade)
                        {
                            swap = student.Value.grade;
                        }
                    }
                    Console.WriteLine("Sinh viên có điểm cao");
                    foreach (var student in arrayList)
                    {
                        if (swap == student.Value.grade)
                        {
                            Console.WriteLine(student.Value.Name + " Grade :" + student.Value.grade);
                        }
                    }
                }
               
                
            }
        }


      
    }
}
