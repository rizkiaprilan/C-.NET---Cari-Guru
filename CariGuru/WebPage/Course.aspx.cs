using CariGuru.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CariGuru.WebPage
{
    public partial class Course : System.Web.UI.Page
    {
        private String pelajaran = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            pelajaran = "";
            gridLbl.Text = pelajaran;
            gridLbl2.Text = "";
            String passVal = Request.QueryString["Category"].ToString();
            if (passVal == "musik")
            {
                musikHld.Visible = true;
                pengetahuanHld.Visible = false;
                olahragaHld.Visible = false;
                GridViewTeacher.Visible = false;
            }
            else if (passVal == "pelajaranSekolah")
            {
                musikHld.Visible = false;
                pengetahuanHld.Visible = true;
                olahragaHld.Visible = false;
                GridViewTeacher.Visible = false;
            }
            else if (passVal == "olahRaga")
            {
                musikHld.Visible = false;
                pengetahuanHld.Visible = false;
                olahragaHld.Visible = true;
                GridViewTeacher.Visible = false;
            }
        }
        void refreshGV()
        {
            Cours course = TeacherRepository.searchCategory(pelajaran);
            if (course != null)
            {
                GridViewTeacher.DataSource = TeacherRepository.getEmail(course.Email);
                GridViewTeacher.DataBind();
            }
            else
            {
                gridLbl2.Text = "NO DATA.";
                GridViewTeacher.Visible = false;
            }
        }

        protected void gitarBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "Gitar";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();

        }

        protected void biolaBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "Biola";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();

        }

        protected void pianoBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "Piano";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();
        }

        protected void drumBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "Drum";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();
        }

        protected void matematikaBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "Matematika";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();
        }

        protected void ipaBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "IPA";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();
        }

        protected void ipsBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "IPS";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();
        }

        protected void bahasaBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "Bahasa";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();
        }

        protected void bolaBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "Bola";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();
        }

        protected void bultangBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "Bulu Tangkis";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();
        }

        protected void berenangBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "Berenang";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();
        }

        protected void silatBtn_Click(object sender, EventArgs e)
        {
            pelajaran = "Silat";
            gridLbl.Text = pelajaran;
            GridViewTeacher.Visible = true;
            refreshGV();
        }





    }
}