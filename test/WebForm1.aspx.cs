using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("PageLoad");
        }

        protected void btnText_Click(object sender, EventArgs e)
        {
            Response.Write("PageLoad :" + " btnText_Click ");
        }

    }
}