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
            string path = Server.MapPath("~");

            using (StreamReader reader = new StreamReader(path + "Greetings.txt"))
            {
                greetings = reader.ReadToEnd();
            }
        }
    }
}