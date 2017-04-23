using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteProject
{
    public partial class End : System.Web.UI.Page
    {
        public string msg;
        public string speech;
        public string prizeStr;

        private User user;
        private DBUtil dbUtil;

        protected void Page_Load(object sender, EventArgs e)
        {
            user = (User)Session["userObj"];

            if (user == null)
            {
                Response.Redirect("Main.aspx");
                return;
            }

            dbUtil = new DBUtil();

            string state = Request.Form["state"];

            if (state == "failure")
            {
                msg = "אופס.....";
                speech = "הדרך לגאולה עוד ארוכה.....";

                user.SetFailCount(user.GetFailCount() + 1);
                dbUtil.UpdateUser(user);

                return;
            }
            else
            {
                msg = "ישתבח שמו לעד!";
                speech = "המשך כך!";
            }

            double delta = double.Parse(Request.Form["delta"]);

            int verseId = int.Parse(Session["verseId"].ToString());
            Session["verseId"] = null;

            Verse verse = dbUtil.GetVerseById(verseId);
            double bestTime = verse.GetBestTime();

            double ratio = delta / bestTime;

            if (delta < bestTime)
            {
                verse.SetBestTime((float)delta);
                dbUtil.UpdateVerse(verse);
            }

            int prize = CalculatePrize(ratio);
            prizeStr = "זכית ב-" + prize.ToString() + " סוכריות טופי!";

            user.SetTofiCount(user.GetTofiCount() + prize);
            int rank = dbUtil.GetRankFromTofiCount(user.GetTofiCount());
            user.SetRank(rank);
            user.SetSolveCount(user.GetSolveCount() + 1);

            dbUtil.UpdateUser(user);
        }
        
        private int CalculatePrize(double ratio)
        {
            return (int)((1.0 / ratio) * 1000);
        }
    }
}