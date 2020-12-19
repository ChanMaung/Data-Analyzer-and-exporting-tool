using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using A8Library;

namespace A8.Member
{
    public partial class MemberPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e) //sign out button
        {
            FormsAuthentication.SignOut();           
            Server.Transfer("../Default.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e) // add value to txt file
        {
            
            A6S.Service1Client dataS = new A6S.Service1Client();
            string s = TextBox1.Text;
            string op = "Add";
            Label1.Text = dataS.Data(s, op);
            Label1.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e) // remove value from txt file
        {
            A6S.Service1Client dataS = new A6S.Service1Client();
            string s = TextBox1.Text;
            string op = "Remove";
            Label1.Text = dataS.Data(s, op);
            Label1.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e) // delete txt file
        {
            A6S.Service1Client dataS = new A6S.Service1Client();
            string s = TextBox1.Text;
            string op = "Reset";
            Label1.Text = dataS.Data(s, op);
            Label1.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e) // get min
        {
            A6S.Service1Client MathS = new A6S.Service1Client();
            string s = "min";
            Label2.Text = MathS.Math(s);
            Label2.Visible = true;
        }

        protected void Button6_Click(object sender, EventArgs e) // get max
        {
            A6S.Service1Client MathS = new A6S.Service1Client();
            string s = "max";
            Label2.Text = MathS.Math(s);
            Label2.Visible = true;
        }

        protected void Button7_Click(object sender, EventArgs e) //get mean
        {
            A6S.Service1Client MathS = new A6S.Service1Client();
            string s = "mean";
            Label2.Text = MathS.Math(s);
            Label2.Visible = true;
        }

        protected void Button8_Click(object sender, EventArgs e) // get median
        {
            A6S.Service1Client MathS = new A6S.Service1Client();
            string s = "median";
            Label2.Text = MathS.Math(s);
            Label2.Visible = true;
        }

        protected void Button9_Click(object sender, EventArgs e) //get mode
        {
            A6S.Service1Client MathS = new A6S.Service1Client();
            string s = "mode";
            Label2.Text = MathS.Math(s);
            Label2.Visible = true;
        }

        protected void Button10_Click(object sender, EventArgs e) // create txt file with results
        {
            A6S.Service1Client MathS = new A6S.Service1Client();
            string s = TextBox2.Text;
            Label3.Text = MathS.ExportResult(s);
            Label3.Visible = true;
        }



    }
}