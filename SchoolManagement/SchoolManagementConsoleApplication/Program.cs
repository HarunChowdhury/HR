using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Manager;
using SchoolManagement.Model;

namespace SchoolManagementConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Name = "Harun", Address = "Rowmari", Phone = "0124654" };
            Student student1 = new Student() { Name = "Kamal", Address = "Rajibpur", Phone = "2654984" };

            StudentManager manager = new StudentManager();

            List<Student> students=manager.GetStudent();
            manager.Add(student);
            manager.Add(student1);
            foreach (var aStudent in students)
            {
                Console.WriteLine("Name :"+aStudent.Name+" "+ aStudent.Address); 
            }

            {
                Console.WriteLine("Name :" + aStudent.Name + " " + aStudent.Address);
            }

            {
                Console.WriteLine("Name :" + aStudent.Name + " " + aStudent.Address);
            }

            {
                Console.WriteLine("Name :" + aStudent.Name + " " + aStudent.Address);
            }

           // Console.WriteLine("Save Data Successfull");
            Console.ReadKey();

        }
    }
}
