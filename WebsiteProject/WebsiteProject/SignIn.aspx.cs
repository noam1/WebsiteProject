using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteProject
{
    public partial class SignIn : System.Web.UI.Page
    {
        public string errorMessage = "";
        private DBUtil dbUtil;

        protected void Page_Load(object sender, EventArgs e)
        {
            dbUtil = new DBUtil();

            if (Request.HttpMethod == "POST")
            {
                string username = Request.Form["username"];
                string password = Request.Form["password"];

                bool success = dbUtil.CheckLogIn(username, password);

                if (!success)
                {
                    errorMessage = "*שם משתמש או סיסמא שגויים";
                }
                else
                {
                    User user = dbUtil.GetUserByUsername(username);
                    Session["userObj"] = user;

                    Response.Redirect("Profile.aspx");
                }
            }
        }
    }
}