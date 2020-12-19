using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace A8
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e) //member reg button
        {
            Response.Redirect("MemberRegPage.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)//member login button
        {
            Response.Redirect("MemberLoginPage.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)//staffpage1 login button
        {
            Response.Redirect("StaffPage1Login.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)//staffpage2 login button
        {
            Response.Redirect("StaffPage2Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)//member page button
        {
            Response.Redirect("Member/MemberPage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e) //staffpage1  button
        {
            Response.Redirect("Staff1/StaffPage1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e) //staffpage2 button
        {
            Response.Redirect("Staff2/StaffPage2.aspx");
        }
    }
}