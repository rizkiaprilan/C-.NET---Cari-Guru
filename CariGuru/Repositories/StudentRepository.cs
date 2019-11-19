using CariGuru;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariGuru.Repositories
{
    public class StudentRepository
    {
        static UserEntities1 db = new UserEntities1();
        public static void InsertStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public static Student findStudent(String email, String password)
        {
            return db.Students.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
        }

        public static List<Student> getStudent(String email, String Password)
        {
            return db.Students.Where(x => x.Email == email && x.Password == Password).ToList();
        }

        public static Student searchEmail(String email)
        {
            return db.Students.Where(x => x.Email == email).FirstOrDefault();
        }
    }
}