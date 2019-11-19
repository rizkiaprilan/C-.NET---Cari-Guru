using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariGuru.Factories
{
    public class TeacherFactory
    {
        public static Teacher createTeacher(String name, String password, String email, String gender, String address,
            String dob, String telephone, String cv, String ijazah, String ktp, float rating, String photo)
        {
            Teacher tch = new Teacher();

            tch.Name = name;
            tch.Password = password;
            tch.Email = email;
            tch.Gender = gender;
            tch.Address = address;
            tch.DOB = dob;
            tch.Telephone = telephone;
            tch.CV = cv;
            tch.Ijazah = ijazah;
            tch.KTP = ktp;
            tch.Rating = rating;
            tch.Photo = photo;

            return tch;
        }

        public static Cours createCategory1(String detail, String detail2, String email)
        {
            Cours course = new Cours();

            course.Detail1 = detail;
            course.Detail2 = detail2;
            course.Email = email;
            return course;
        }

        public static Schedule createSchedule(int su, int mo, int tu, int wd, int thu, int fri, int sat, String email)
        {
            Schedule schedule = new Schedule();

            schedule.Sunday = su;
            schedule.Monday = mo;
            schedule.Tuesday = tu;
            schedule.Wednesday = wd;
            schedule.Thursday = thu;
            schedule.Friday = fri;
            schedule.Saturday = sat;
            schedule.Email = email;

            return schedule;
        }
    }
}