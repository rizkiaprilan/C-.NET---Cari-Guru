using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CariGuru.Factories
{
    public class Studentfactory
    {
        public static Student createStudent(String name, String password, String email, String gender, String address,
            String dob, String telephone, String Degree, String city, String province, String photo)
        {
            Student std = new Student();

            std.Name = name;
            std.Password = password;
            std.Email = email;
            std.Gender = gender;
            std.Address = address;
            std.DOB = dob;
            std.Telephone = telephone;
            std.Degree = Degree;
            std.City = city;
            std.Province = province;
            std.Photo = photo;

            return std;
        }
    }
}