using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace A8.Staff
{
    public partial class StaffPage2Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Members.xml";
            string user = TextBox1.Text;
            string password = TextBox2.Text;

            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);    // open file
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["name"].InnerText == user)
                {
                    if (node["pwd"].InnerText == password)
                    {
                        Label3.Visible = false;
                        FormsAuthentication.RedirectFromLoginPage(user, true);

                        Response.Redirect("Staff2/StaffPage2.aspx");
                        return;
                    }
                    else
                    {//if username exists but password does match. 
                        Label3.Visible = true;
                        return;
                    }
                }
            }
            Label3.Text = "User Name not found";
            Label3.Visible = true;
            return;
        }
    }
}