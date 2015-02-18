using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Model;

namespace SchoolManagement.Manager
{
   public class StudentManager
   {
       private SchoolManagementDbEntities Db;
       public StudentManager()
       {
           Db = new SchoolManagementDbEntities();
       }

       public void Add(Student aStudent)
       {
           //GET STUDENT from database

           DbSet<Student> students = Db.Students;

           students.Add(aStudent);

           Db.SaveChanges();
       }


       public void Delete(int id)
       {
           /*   Student s =(from student in Db.Students
           where student.Id == id
           select student).FirstOrDefault(); */
         // Student s =(Db.Students.Where(student => student.Id == id)).FirstOrDefault();
           Student s = Db.Students.FirstOrDefault(student => student.Id == id);

       }

       public List<Student> GetStudent()
       {
           return Db.Students.ToList();
       }

   }
}
