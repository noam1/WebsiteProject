using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteProject
{
    public partial class SignUp : System.Web.UI.Page
    {
        public string errorMessage = "";
        private DBUtil dbUtil;

        protected void Page_Load(object sender, EventArgs e)
        {
            dbUtil = new DBUtil();

            if (Request.HttpMethod == "POST")
            {
                string fullName = Request.Form["fullname"];
                string username = Request.Form["username"];
                string password = Request.Form["password"];
                string email = Request.Form["email"];

                User user = dbUtil.AddUser(fullName, username, password, email);

                if (user == null)
                {
                    errorMessage = "*שם המשתמש קיים כבר";
                }
                else
                {
                    Session["userObj"] = user;
                    Response.Redirect("Profile.aspx");
                }
            }
        }
    }
}