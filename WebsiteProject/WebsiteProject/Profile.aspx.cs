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
            }
            else if(Request.Form["change"] != null)
            {

            }
        }
    }
}