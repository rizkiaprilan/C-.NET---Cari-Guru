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
    public partial class RegistTeacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registBtn_Click(object sender, EventArgs e)
        {
            int errorCount = 0;
            String genderTxt = "";
            DateTime birth = DateTime.Now;
            String file = Path.GetFileName(cvUpload.FileName);
            String file1 = Path.GetFileName(ktpUpload.FileName);
            String file2 = Path.GetFileName(ijazahUpload.FileName);
            String file3 = Path.GetFileName(photoUpload.FileName);

            if (TeacherRepository.searchEmail(emailTxT.Text) == null)
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


                if (cvUpload.HasFile)
                {
                    string folderPath = Server.MapPath("~/Images/");

                    //Check whether Directory (Folder) exists.
                    if (!Directory.Exists(folderPath))
                    {
                        //If Directory (Folder) does not exists Create it.
                        Directory.CreateDirectory(folderPath);
                    }

                    //Save the File to the Directory (Folder).
                    cvUpload.SaveAs(folderPath + Path.GetFileName(cvUpload.FileName));


                    cvLbl.Text = file + " Upload Success..";
                }

                else
                {
                    cvLbl.Text = "Upload your CV";
                    errorCount++;
                }

                if (ktpUpload.HasFile)
                {
                    string folderPath = Server.MapPath("~/Images/");

                    //Check whether Directory (Folder) exists.
                    if (!Directory.Exists(folderPath))
                    {
                        //If Directory (Folder) does not exists Create it.
                        Directory.CreateDirectory(folderPath);
                    }

                    //Save the File to the Directory (Folder).
                    ktpUpload.SaveAs(folderPath + Path.GetFileName(ktpUpload.FileName));


                    ktpLbl.Text = file1 + " Upload Success..";
                }

                else
                {
                    errorCount++;
                    ktpLbl.Text = "Upload KTP";
                }

                if (ijazahUpload.HasFile)
                {
                    string folderPath = Server.MapPath("~/Images/");

                    //Check whether Directory (Folder) exists.
                    if (!Directory.Exists(folderPath))
                    {
                        //If Directory (Folder) does not exists Create it.
                        Directory.CreateDirectory(folderPath);
                    }

                    //Save the File to the Directory (Folder).
                    ijazahUpload.SaveAs(folderPath + Path.GetFileName(ijazahUpload.FileName));


                    ijazahLbl.Text = file2 + " Upload Success..";
                }

                else
                {
                    errorCount++;
                    ijazahLbl.Text = "Upload Ijazah";
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


                    photoLbl.Text = file3 + " Upload Success..";
                }

                else
                {
                    errorCount++;
                    photoLbl.Text = "Upload Photo";
                }



            }
            else
            {
                emailLbl.Text = "Email sudah dipakai";
                errorCount++;
            }

            if (errorCount == 0)
            {
                file = "~/Images/" + Path.GetFileName(cvUpload.FileName);
                file1 = "~/Images/" + Path.GetFileName(ktpUpload.FileName);
                file2 = "~/Images/" + Path.GetFileName(ijazahUpload.FileName);
                file3 = "~/Images/" + Path.GetFileName(photoUpload.FileName);
                Teacher teacher = TeacherFactory.createTeacher(usernameTxt.Text, passwordTxt.Text, emailTxT.Text, genderTxt, Textarea1.InnerText, birthTxt.Text, phoneTxt.Text
                    , file, file1, file2, 0, file3);
                Cours course = TeacherFactory.createCategory1(" ", " " , emailTxT.Text);
                Schedule schedule = TeacherFactory.createSchedule(0, 0, 0, 0, 0, 0, 0, emailTxT.Text);
                
                TeacherRepository.insertTeacher(teacher);
                TeacherRepository.insertCategory(course);
                TeacherRepository.insertSchedule(schedule);
                Response.Redirect("Home.aspx");

            }

        }
    }
}