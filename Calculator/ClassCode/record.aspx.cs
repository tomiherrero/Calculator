using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator.ClassCode
{
    public partial class record : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void txtRecord_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnRecord_Click(object sender, EventArgs e)
        {
            if (Session["Record"] != null)
                lblRecord.Text = Session["Record"].ToString();
                btnDelete.Enabled = true;

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            lblRecord.Text = string.Empty;
            Session["Record"] = string.Empty;
        }
    }
}