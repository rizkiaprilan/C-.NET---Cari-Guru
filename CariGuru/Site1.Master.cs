using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CariGuru.Repositories;

namespace CariGuru
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if (Request.Cookies["role"] != null)
            {
                Session["role"] = Request.Cookies["role"].Value;
            }

			if (Request.Path.ToLower().EndsWith("home.aspx")){
				home.BackColor = System.Drawing.ColorTranslator.FromHtml("#003044");
			}

			if (Request.Path.ToLower().EndsWith("profile.aspx")){
				myProfile.BackColor = System.Drawing.ColorTranslator.FromHtml("#003044");
			}

			if (Request.Path.ToLower().EndsWith("course.aspx")){
				course.Style.Add("background-color" , "#003044");
			}

			if (Request.Path.ToLower().EndsWith("myschedule.aspx")){
				mySchedule.BackColor = System.Drawing.ColorTranslator.FromHtml("#003044");
			}

			if (Request.Path.ToLower().EndsWith("about.aspx")){
				about.BackColor = System.Drawing.ColorTranslator.FromHtml("#003044");
			}

           
            //course.Visible = false;
            //logout.Visible = false;
            //myProfile.Visible = false;
            //mySchedule.Visible = false;
            welcome.Visible = false;
            logoutHld.Visible = false;
            loginHld.Visible = true;
            navHld.Visible = false;
            //if(Session["role"] != null)
            //{
            //	if(Session["role"] == "Teacher")
            //	{
            //		logout.Visible = true;
            //		login.Visible = false;
            //		myProfile.Visible = true;
            //		mySchedule.Visible = true;
            //	}
            //	else
            //	{
            //		logout.Visible = true;
            //		login.Visible = false;
            //		myProfile.Visible = true;
            //		course.Visible = true;
            //	}
            //}

            if (Session["username"] != null)
            {
                welcome.Visible = true;
                logoutHld.Visible = true;
                loginHld.Visible = false;
                navHld.Visible = true;
                usernameLbl.Text = Session["username"].ToString();
            }


        }
        //protected void visible_Click(object sender, EventArgs e)
        //{
            
        //}

        protected void musik_Click(object sender, EventArgs e)
        {
			Response.Redirect("Course.aspx?Category=musik");
		}

		protected void pelajaranSekolah_Click(object sender, EventArgs e)
        {
			Response.Redirect("Course.aspx?Category=pelajaranSekolah");
		}

		protected void olahRaga_Click(object sender, EventArgs e)
        {
			Response.Redirect("Course.aspx?Category=olahRaga");
		}

		protected void loginBtn_Click(object sender, EventArgs e)
        {
			Student student_ = new Student();
            Teacher teacher_ = new Teacher();

            if (StudentRepository.findStudent(emailTxt.Text, passwordTxt.Text) != null) 
            {
                Student Temp_Student = StudentRepository.findStudent(emailTxt.Text, passwordTxt.Text);
                Session["username"] = Temp_Student.Name;
                Session["email"] = Temp_Student.Email;
                Response.Redirect("Home.aspx");

            } else if (TeacherRepository.findTeacher(emailTxt.Text, passwordTxt.Text) != null) {
                Teacher Temp_Teacher = TeacherRepository.findTeacher(emailTxt.Text, passwordTxt.Text);
                Session["username"] = Temp_Teacher.Name;
                Session["email"] = Temp_Teacher.Email;
                Response.Redirect("Home.aspx");

            }
            else {
                EmailErrorLblLogin.Text = "Email tidak ditemukan";
                PasswordErrorLblLogin.Text = "Password salah";
            }

            if (rememberMe.Checked)
            {        
                if (TeacherRepository.findTeacher(emailTxt.Text, passwordTxt.Text) != null)
                {
                    HttpCookie cookie = new HttpCookie("role", "Teacher");
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                else if (StudentRepository.findStudent(emailTxt.Text, passwordTxt.Text) != null)
                {
                    HttpCookie cookie = new HttpCookie("role", "Student");
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
            }
            else {
                if (TeacherRepository.findTeacher(emailTxt.Text, passwordTxt.Text) != null)
                {
                    HttpCookie cookie = new HttpCookie("role", "Teacher");
                    cookie.Expires = DateTime.Now.AddMinutes(1);
                    Response.Cookies.Add(cookie);
                }
                else if (StudentRepository.findStudent(emailTxt.Text, passwordTxt.Text) != null)
                {
                    HttpCookie cookie = new HttpCookie("role", "Student");
                    cookie.Expires = DateTime.Now.AddMinutes(1);
                    Response.Cookies.Add(cookie);
                }
            }
		}

		protected void logout_Click(object sender, EventArgs e)
        {
            Response.Cookies["role"].Expires = DateTime.Now.AddMinutes(-1);
            Session["role"] = null;
            Session["username"] = null;
            Session["email"] = null;
            Response.Redirect("Home.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            currTime.Text = DateTime.Now.ToString("HH:mm:ss");
            currDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
        }
    }
}