using CariGuru;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariGuru.Repositories
{
    public class TeacherRepository
    {
        static UserEntities1 db = new UserEntities1();
        public static void insertTeacher(Teacher tch)
        {
            db.Teachers.Add(tch);
            db.SaveChanges();
        }

        public static Teacher findTeacher(String email, string password)
        {
            return db.Teachers.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
        }

        public static Teacher searchEmail(String email)
        {
            return db.Teachers.Where(x => x.Email == email).FirstOrDefault();
        }
        public static Schedule searchEmailSchedule(String email)
        {
            return db.Schedules.Where(x => x.Email == email).FirstOrDefault();
        }


        public static void updateProfile(String name, String email, String Address, String telephone, String cv, String ijazah)
        {

        }

        public static Cours searchEmailCourse(String email)
        {
            return db.Courses.Where(x => x.Email == email).FirstOrDefault();
        }

        public static void updateCourse(String detail, String detail2, String email)
        {
            Cours course = searchEmailCourse(email);
            if (course != null)
            {
                course.Detail1 = detail;
                course.Detail2 = detail2;

                db.SaveChanges();
            }
        }


        public static void insertSchedule(Schedule schedule)
        {
            db.Schedules.Add(schedule);
            db.SaveChanges();
        }
        public static void insertCategory(Cours course)
        {
            db.Courses.Add(course);
            db.SaveChanges();
        }

        public static List<Cours> getAllCourse()
        {
            return db.Courses.ToList();
        }

        public void updateName(String Name)
        {
            Teacher tch = new Teacher();

            tch.Name = Name;
        }

        public static List<Teacher> getTeacher(String email, String Password)
        {
            return db.Teachers.Where(x => x.Email == email && x.Password == Password).ToList();
        }
        public static List<Teacher> getEmail(String email)
        {
            return db.Teachers.Where(x => x.Email == email).ToList();
        }
        public static Cours searchCategory(String category)
        {
            return db.Courses.Where(x => x.Detail1 == category || x.Detail2 == category).FirstOrDefault();
        }

        public static void updateSchedule(int sun, int mon, int tue, int wed, int thu, int fri, int sat, string email)
        {
            Schedule schdl = searchEmailSchedule(email);
            if (schdl != null)
            {
                schdl.Sunday = sun;
                schdl.Monday = mon;
                schdl.Tuesday = tue;
                schdl.Wednesday = wed;
                schdl.Thursday = thu;
                schdl.Friday = fri;
                schdl.Saturday = sat;

                db.SaveChanges();
            }
        }

        public static void updateMonday(int mon, string email)
        {
            Schedule schdl = searchEmailSchedule(email);
            if (schdl != null)
            {
                schdl.Monday = mon;

                db.SaveChanges();
            }
        }

        public static void updateTuesday(int tue, string email)
        {
            Schedule schdl = searchEmailSchedule(email);
            if (schdl != null)
            {
                schdl.Tuesday = tue;

                db.SaveChanges();
            }
        }

        public static void updateWednesday(int wed, string email)
        {
            Schedule schdl = searchEmailSchedule(email);
            if (schdl != null)
            {
                schdl.Wednesday = wed;

                db.SaveChanges();
            }
        }

        public static void updateThursday(int thu, string email)
        {
            Schedule schdl = searchEmailSchedule(email);
            if (schdl != null)
            {
                schdl.Thursday = thu;

                db.SaveChanges();
            }
        }

        public static void updateFriday(int fri, string email)
        {
            Schedule schdl = searchEmailSchedule(email);
            if (schdl != null)
            {
                schdl.Friday = fri;

                db.SaveChanges();
            }
        }

        public static void updateSaturday(int sat, string email)
        {
            Schedule schdl = searchEmailSchedule(email);
            if (schdl != null)
            {
                schdl.Saturday = sat;

                db.SaveChanges();
            }
        }

        public static void updateSunday(int sun, string email)
        {
            Schedule schdl = searchEmailSchedule(email);
            if (schdl != null)
            {
                schdl.Sunday = sun;

                db.SaveChanges();
            }
        }
    }
}