using CariGuru.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CariGuru.WebPage
{
    public partial class MySchedule : System.Web.UI.Page
    {
        protected int mon;
        protected int tue;
        protected int wed;
        protected int thu;
        protected int fri;
        protected int sat;
        protected int sun;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Home.aspx");
            }

            string email = Convert.ToString(Session["email"]);
            if (TeacherRepository.searchEmail(email) != null)
            {


                Schedule schdl = TeacherRepository.searchEmailSchedule(Session["email"].ToString());
                mon = Convert.ToInt32(schdl.Monday);
                tue = Convert.ToInt32(schdl.Tuesday);
                wed = Convert.ToInt32(schdl.Wednesday);
                thu = Convert.ToInt32(schdl.Thursday);
                fri = Convert.ToInt32(schdl.Friday);
                sat = Convert.ToInt32(schdl.Saturday);
                sun = Convert.ToInt32(schdl.Sunday);


                if (mon == 1) { monday.Attributes.Add("style", "background-color: green;"); }
                else { monday.Attributes.Add("style", "background-color: red;"); }

                if (tue == 1) { tuesday.Attributes.Add("style", "background-color: green;"); }
                else { tuesday.Attributes.Add("style", "background-color: red;"); }

                if (wed == 1) { wednesday.Attributes.Add("style", "background-color: green;"); }
                else { wednesday.Attributes.Add("style", "background-color: red;"); }

                if (thu == 1) { thursday.Attributes.Add("style", "background-color: green;"); }
                else { thursday.Attributes.Add("style", "background-color: red;"); }

                if (fri == 1) { friday.Attributes.Add("style", "background-color: green;"); }
                else { friday.Attributes.Add("style", "background-color: red;"); }

                if (sat == 1) { saturday.Attributes.Add("style", "background-color: green;"); }
                else { saturday.Attributes.Add("style", "background-color: red;"); }

                //if(sun == 1){ sunday.Attributes.Add("style", "background-color: green;"); }
                //else{ sunday.Attributes.Add("style", "background-color: red;"); }

            }
        }
        protected void monday_Click(object sender, EventArgs e)
        {
            if (mon == 0)
            {
                mon = 1;
                monday.Attributes.Add("style", "background-color: green;");
                TeacherRepository.updateMonday(mon, Convert.ToString(Session["email"]));
            }
            else if (mon == 1)
            {
                mon = 0;
                monday.Attributes.Add("style", "background-color: red;");
                TeacherRepository.updateMonday(mon, Convert.ToString(Session["email"]));
            }
        }

        protected void tuesday_Click(object sender, EventArgs e)
        {
            if (tue == 0)
            {
                tue = 1;
                tuesday.Attributes.Add("style", "background-color: green;");
                TeacherRepository.updateTuesday(tue, Convert.ToString(Session["email"]));
            }
            else if (tue == 1)
            {
                tue = 0;
                tuesday.Attributes.Add("style", "background-color: red;");
                TeacherRepository.updateTuesday(tue, Convert.ToString(Session["email"]));
            }
        }

        protected void wednesday_Click(object sender, EventArgs e)
        {
            if (wed == 0)
            {
                wed = 1;
                wednesday.Attributes.Add("style", "background-color: green;");
                TeacherRepository.updateWednesday(wed, Convert.ToString(Session["email"]));
            }
            else if (wed == 1)
            {
                wed = 0;
                wednesday.Attributes.Add("style", "background-color: red;");
                TeacherRepository.updateWednesday(wed, Convert.ToString(Session["email"]));
            }
        }

        protected void thursday_Click(object sender, EventArgs e)
        {
            if (thu == 0)
            {
                thu = 1;
                thursday.Attributes.Add("style", "background-color: green;");
                TeacherRepository.updateThursday(thu, Convert.ToString(Session["email"]));
            }
            else if (thu == 1)
            {
                thu = 0;
                thursday.Attributes.Add("style", "background-color: red;");
                TeacherRepository.updateThursday(thu, Convert.ToString(Session["email"]));
            }
        }

        protected void friday_Click(object sender, EventArgs e)
        {
            if (fri == 0)
            {
                fri = 1;
                friday.Attributes.Add("style", "background-color: green;");
                TeacherRepository.updateFriday(fri, Convert.ToString(Session["email"]));
            }
            else if (fri == 1)
            {
                fri = 0;
                friday.Attributes.Add("style", "background-color: red;");
                TeacherRepository.updateFriday(fri, Convert.ToString(Session["email"]));
            }
        }

        protected void saturday_Click(object sender, EventArgs e)
        {
            if (sat == 0)
            {
                sat = 1;
                saturday.Attributes.Add("style", "background-color: green;");
                TeacherRepository.updateSaturday(sat, Convert.ToString(Session["email"]));
            }
            else if (sat == 1)
            {
                sat = 0;
                saturday.Attributes.Add("style", "background-color: red;");
                TeacherRepository.updateSaturday(sat, Convert.ToString(Session["email"]));
            }
        }

        //protected void edit_Click(object sender, EventArgs e){
        //	if(monday.Enabled = true){
        //		monday.Enabled = false;
        //		tuesday.Enabled = false;
        //		wednesday.Enabled = false;
        //		thursday.Enabled = false;
        //		friday.Enabled = false;
        //		saturday.Enabled = false;
        //	}
        //	else{
        //		monday.Enabled = true;
        //		tuesday.Enabled = true;
        //		wednesday.Enabled = true;
        //		thursday.Enabled = true;
        //		friday.Enabled = true;
        //		saturday.Enabled = true;
        //	}
        //	
        //}

        //protected void Sunday_Click(object sender, EventArgs e){
        //	if(sun == 0){
        //		sun = 1;
        //		sunday.Attributes.Add("style", "background-color: green;");
        //		TeacherRepository.updateSunday(sun,Convert.ToString(Session["email"]));
        //	}
        //	else if(sun == 1){
        //		sun = 0;
        //		sunday.Attributes.Add("style", "background-color: red;");
        //		TeacherRepository.updateSunday(sun,Convert.ToString(Session["email"]));
        //	}
        //}
    }
}