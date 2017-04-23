using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;

namespace WebsiteProject
{
    public partial class Main : System.Web.UI.Page
    {
        public string greetings = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            DBUtil util = new DBUtil();

            if (Session["userObj"] != null)
            {
                Response.Redirect("Profile.aspx");
                return;
            }

            if (Request.HttpMethod == "GET")
            {
                string path = Server.MapPath("~");

                using (StreamReader reader = new StreamReader(path + "Greetings.txt"))
                {
                    greetings = reader.ReadToEnd();
                }
            }
            else
            {
                if (Request.Form["signUp"] != null)
                    Response.Redirect("SignUp.aspx");
                else
                    Response.Redirect("SignIn.aspx");
            }
        }
    }
}