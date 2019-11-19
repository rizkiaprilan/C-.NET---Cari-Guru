using CariGuru.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CariGuru.WebPage
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            string email = Convert.ToString(Session["Email"]);
            if (TeacherRepository.searchEmail(email) != null)
            {
                teacherHolder.Visible = true;
                teacherHolder1.Visible = true;
                studentHolder.Visible = false;
                studentHolder1.Visible = false;
                Teacher teacher_ = TeacherRepository.searchEmail(email);
                profileImage.ImageUrl = teacher_.Photo;
                NameTxt.Text = teacher_.Name;
                EmailTxt.Text = teacher_.Email;
                GenderTxt.Text = teacher_.Gender;
                AddressTxt.Text = teacher_.Address;
                DOBTxt.Text = teacher_.DOB;
                TelephoneTxt.Text = teacher_.Telephone;
                CVImg.ImageUrl = teacher_.CV;
                IjazahImg.ImageUrl = teacher_.Ijazah;
                KTPImg.ImageUrl = teacher_.KTP;
                RatingTxt.Text = Convert.ToString(teacher_.Rating);
                Cours course = TeacherRepository.searchEmailCourse(email);
                if (course.Detail1 != null)
                {
                    detail1Txt.Text = course.Detail1;
                }
                else detail1Txt.Text = " ";

                if (course.Detail2 != null)
                {
                    detail2Txt.Text = course.Detail2;

                }else detail2Txt.Text = " ";

            }
            else if (StudentRepository.searchEmail(email) != null)
            {
                teacherHolder.Visible = false;
                teacherHolder1.Visible = false;
                studentHolder.Visible = true;
                studentHolder1.Visible = true;
                Student student_ = StudentRepository.searchEmail(email);
                profileImage.ImageUrl = student_.Photo;
                NameTxt.Text = student_.Name;
                EmailTxt.Text = student_.Email;
                GenderTxt.Text = student_.Gender;
                AddressTxt.Text = student_.Address;
                DOBTxt.Text = student_.DOB;
                TelephoneTxt.Text = student_.Telephone;
                Degreetxt.Text = student_.Degree;
                CityTxt.Text = student_.City;
                ProvinceTxt.Text = student_.Province;
            }
            if (category1.SelectedItem.Text == "Select Item")
            {
                detailMusik1.Visible = false;
                detailOlahraga1.Visible = false;
                detailPengetahuan1.Visible = false;
            }
            if (category2.SelectedItem.Text == "Select Item")
            {
                detailMusik2.Visible = false;
                detailOlahraga2.Visible = false;
                detailPengetahuan2.Visible = false;
            }
            
        }
        protected void category1DL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category1.SelectedItem.Text == "Musik")
            {
                detailMusik1.Visible = true;
                detailOlahraga1.Visible = false;
                detailPengetahuan1.Visible = false;
            }
            else if (category1.SelectedItem.Text == "Pengetahuan")
            {
                detailMusik1.Visible = false;
                detailOlahraga1.Visible = false;
                detailPengetahuan1.Visible = true;
            }
            else if(category1.SelectedItem.Text == "Olahraga")
            {
                detailMusik1.Visible = false;
                detailOlahraga1.Visible = true;
                detailPengetahuan1.Visible = false;
            }

        }
        protected void category2DL_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (category2.SelectedItem.Text == "Musik")
            {
                detailMusik2.Visible = true;
                detailOlahraga2.Visible = false;
                detailPengetahuan2.Visible = false;
            }
            else if (category2.SelectedItem.Text == "Pengetahuan")
            {
                detailMusik2.Visible = false;
                detailOlahraga2.Visible = false;
                detailPengetahuan2.Visible = true;
            }
            else if (category2.SelectedItem.Text == "Olahraga")
            {
                detailMusik2.Visible = false;
                detailOlahraga2.Visible = true;
                detailPengetahuan2.Visible = false;
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            Cours course = TeacherRepository.searchEmailCourse(Session["email"].ToString());
            String detail = course.Detail1;
            String detail2 = course.Detail2;
            if (detailMusik1.Visible==true)
            {
                detail = detailMusik1.SelectedItem.Text;
            }
            else if (detailOlahraga1.Visible == true)
            {
                detail = detailOlahraga1.SelectedItem.Text;
            }
            else if (detailPengetahuan1.Visible == true)
            {
                detail = detailPengetahuan1.SelectedItem.Text;
            }

            if (detailMusik2.Visible == true)
            {
                detail2 = detailMusik2.SelectedItem.Text;
            }
            else if (detailOlahraga2.Visible == true)
            {
                detail2 = detailOlahraga2.SelectedItem.Text;
            }
            else if (detailPengetahuan2.Visible == true)
            {
                detail2 = detailPengetahuan2.SelectedItem.Text;
            }

            TeacherRepository.updateCourse(detail, detail2, course.Email);
            Response.Redirect("Profile.aspx");
        }
    }
}