using CariGuru.Factories;
using CariGuru.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CariGuru.WebPage
{
    public partial class RegistStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int errorCount = 0;
            string genderTxt = "";
            DateTime birth = DateTime.Now;
            String file = Path.GetFileName(photoUpload.FileName);

            if (StudentRepository.searchEmail(emailTxT.Text) == null)
            {
                if (birthTxt.Text != "")
                {
                    birth = DateTime.Parse(birthTxt.Text);
                }

                if (usernameTxt.Text == "")
                {
                    usernameLbl.Text = "Can't be empty..";
                    errorCount++;
                }
                else
                {
                    usernameLbl.Text = "";
                }

                if (passwordTxt.Text == "")
                {
                    passwordLbl.Text = "Password more than 8 character..";
                    errorCount++;
                }
                else
                {
                    passwordLbl.Text = "";
                }


                if (emailTxT.Text == "")
                {
                    emailLbl.Text = "Can't be empty..";
                    errorCount++;
                }

                else
                {
                    emailLbl.Text = "";
                }

                if (maleBtn.Checked == false && femaleBtn.Checked == false)
                {
                    genderLbl.Text = "Gender must be chosen..";
                    errorCount++;
                }
                else if (maleBtn.Checked)
                {
                    genderTxt = "Male";
                    genderLbl.Text = "";
                }
                else if (femaleBtn.Checked)
                {
                    genderTxt = "Female";
                    genderLbl.Text = "";
                }

                if (Textarea1.InnerText.Length < 5)
                {
                    errorCount++;
                    Label2.Text = "Address too short";
                }
                else
                {
                    Label2.Text = "";
                }

                if (phoneTxt.Text.ToString().Length < 10 || phoneTxt.Text.ToString().Length > 12)
                {
                    phoneLbl.Text = "Phone number must be [10 - 12] numbers";
                    errorCount++;
                }
                else if (!phoneTxt.Text.All(char.IsDigit))
                {
                    phoneLbl.Text = "Must numbers";
                    errorCount++;
                }

                else
                {
                    phoneLbl.Text = "";
                }


                if (DateTime.Now.Year - birth.Year < 4)
                {
                    birthLbl.Text = "Your age must be above 4 years of age..";
                    errorCount++;
                }

                else
                {
                    birthLbl.Text = "";
                }

                if (cityTxt.Text == "")
                {
                    errorCount++;
                    cityLbl.Text = "Must be Filled";
                }
                else
                {
                    cityLbl.Text = "";
                }

                if (DropDownListProvince.SelectedItem.Text == "Select Province")
                {
                    errorCount++;
                    provinceLbl.Text = "Must be Filled";
                }
                else
                {
                    provinceLbl.Text = "";
                }

                if (degreeDL.SelectedItem.Text == "Select Degree")
                {
                    degreeLbl.Text = "Must be Filled";
                    errorCount++;
                }
                else
                {
                    degreeLbl.Text = "";
                }
                if (photoUpload.HasFile)
                {
                    string folderPath = Server.MapPath("~/Images/");

                    //Check whether Directory (Folder) exists.
                    if (!Directory.Exists(folderPath))
                    {
                        //If Directory (Folder) does not exists Create it.
                        Directory.CreateDirectory(folderPath);
                    }

                    //Save the File to the Directory (Folder).
                    photoUpload.SaveAs(folderPath + Path.GetFileName(photoUpload.FileName));


                    photoLbl.Text = file + " Upload Success..";
                }

                else
                {
                    errorCount++;
                    photoLbl.Text = "Upload Photo";
                }
            }
            else
            {
                emailLbl.Text = "Cannot take an existing Email..";
                errorCount++;
            }
            

            if (errorCount == 0)
            {
                file = "~/Images/" + Path.GetFileName(photoUpload.FileName);
                Student student = Studentfactory.createStudent(usernameTxt.Text, passwordTxt.Text, emailTxT.Text
                    , genderTxt, Textarea1.InnerText, birthTxt.Text, phoneTxt.Text, degreeDL.SelectedItem.Text, cityTxt.Text, DropDownListProvince.SelectedItem.Text, file);

                StudentRepository.InsertStudent(student);
                Response.Redirect("Home.aspx");
            }
        }

    }
}