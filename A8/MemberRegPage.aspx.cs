using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace A8.Member
{
    public partial class MemberRegPage : System.Web.UI.Page
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
            myDoc.Load(filepath);                       // open file

            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["name"].InnerText == user)
                {
                    Label3.Text = String.Format("*Account with user name {0} already exists.", user);
                    Label3.Visible = true;
                    return;
                }
            }
            Label3.Visible = false;
           
            

            XmlElement myMember = myDoc.CreateElement("member", rootElement.NamespaceURI);
            rootElement.AppendChild(myMember);
            XmlElement myUser = myDoc.CreateElement("name", rootElement.NamespaceURI);
            myMember.AppendChild(myUser);
            myUser.InnerText = user;

            XmlElement myPwd = myDoc.CreateElement("pwd", rootElement.NamespaceURI);
            myMember.AppendChild(myPwd);
            myPwd.InnerText = password;

            myDoc.Save(filepath);



        }

        protected void Button2_Click(object sender, EventArgs e) //mem login page
        {
            Response.Redirect("MemberLoginPage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e) // public page
        {
            Response.Redirect("Default.aspx");
        }
    }
}