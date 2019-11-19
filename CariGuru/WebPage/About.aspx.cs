using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CariGuru.WebPage
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Guru.Visible = false;
            Murid.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Murid.Visible = false;
            Guru.Visible = true;
        }
    }
}