using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebsiteProject
{
    public partial class Game : System.Web.UI.Page
    {
        public string script = "";

        private DBUtil dbUtil;
        private Verse verse;

        private User user;

        protected void Page_Load(object sender, EventArgs e)
        {
            user = (User)Session["userObj"];

            if (user == null)
            {
                Response.Redirect("Main.aspx");
                return;
            }

            dbUtil = new DBUtil();

            verse = dbUtil.GetRandomVerse();

            GenVerseText();
            GenClearArray();
            GenRawArray();

            Session["verseId"] = verse.GetId();
        }

        private void GenVerseText()
        {
            string jsVar = "var verse = '" + verse.GetRaw() + "';";

            script += jsVar + "\n\n";
        }

        private void GenClearArray()
        {
            string cleaned = verse.GetCleaned();
            string jsArray = "var clean = [";

            for (int i = 0; i < cleaned.Length; i++)
                jsArray += "'" + cleaned[i] + "', ";

            jsArray = jsArray.Remove(jsArray.Length - 2, 2);
            jsArray += "];";

            script += jsArray + "\n\n";
        }

        private void GenRawArray()
        {
            string raw = verse.GetRaw();
            string jsArray = "var raw = [";

            List<string> letters = new List<string>();

            int index = raw.Length - 1;

            while (raw.Length != 0)
            {
                if (!isHebrewLetter(raw[index]) && raw[index] != ' ')
                {
                    index--;
                    continue;
                }

                string letter = raw.Substring(index, raw.Length - index);
                raw = raw.Remove(index, raw.Length - index);

                letters.Add(letter);

                index = raw.Length - 1;
            }

            for (int i = letters.Count - 1; i >= 0; i--)
                jsArray += "'" + letters[i] + "', ";

            jsArray = jsArray.Remove(jsArray.Length - 2, 2);
            jsArray += "];";

            script += jsArray;
        }

        private bool isHebrewLetter(char c)
        {
            return (c >= 'א' && c <= 'ת');
        }
    }
}