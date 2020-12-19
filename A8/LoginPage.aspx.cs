using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A8
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) //member login
        {
            Response.Redirect("MemberLoginPage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e) //staff 1
        {
            Response.Redirect("StaffPage1Login.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)//staff 2
        {
            Response.Redirect("StaffPage2Login.aspx");
        }
    }
}