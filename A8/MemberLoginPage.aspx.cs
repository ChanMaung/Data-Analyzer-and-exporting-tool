using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace A8.Member
{
    public partial class MemberLoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string BaseUri = "http://neptune.fulton.ad.asu.edu/WSRepository/Services/RandomString/Service.svc/GetRandomString/3";

            string CompleteUri = BaseUri;
            Uri U = new Uri(CompleteUri);

            WebClient channel = new WebClient(); // create a channel
            byte[] abc = channel.DownloadData(CompleteUri); // return byte array
            Stream strm = new MemoryStream(abc); // convert to mem stream
            DataContractSerializer obj = new DataContractSerializer(typeof(string));
            string randString = obj.ReadObject(strm).ToString(); // convent to string
            Label4.Text = randString;
            Label4.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e) // login button
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

                        Response.Redirect("Member/MemberPage.aspx");
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

        protected void Button2_Click(object sender, EventArgs e) //mem reg page
        {
            Response.Redirect("MemberRegPage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)// public page
        {
            Response.Redirect("Default.aspx");
        }
    }
}