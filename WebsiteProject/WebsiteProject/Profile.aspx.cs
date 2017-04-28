using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteProject
{
    public partial class Profile : System.Web.UI.Page
    {
        public string fullName;
        public string username;
        public int tofiCount;
        public string rank;
        public string successCount;
        public string failCount;
        public string ratio;

        private User user;
        private DBUtil dbUtil;

        protected void Page_Load(object sender, EventArgs e)
        {
            dbUtil = new DBUtil();

            user = (User)Session["userObj"];

            if (user == null)
            {
                Response.Redirect("Main.aspx");
                return;
            }

            fullName = user.GetFullName();
            username = user.GetUserName();
            tofiCount = user.GetTofiCount();

            int rankNum = user.GetRank();
            rank = dbUtil.GetRankName(rankNum);

            int succes = user.GetSolveCount();
            int fail = user.GetFailCount();
            ratio = (((float)succes / fail) * 100).ToString();

            successCount = succes.ToString();
            failCount = fail.ToString();
            
            // Send to game screen.
            if (Request.Form["play"] != null)
            {
                Response.Redirect("Game.aspx");
                return;
            }
            else if (Request.Form["disconnect"] != null)
            {
                Session["userObj"] = null;
                Response.Redirect("Main.aspx");
                return;
            }
            else if(Request.Form["delete"] != null)
            {
                dbUtil.DeleteUser(user);
                Session["userObj"] = null;
                Response.Redirect("Main.aspx");
                return;
            }
        }
    }
}