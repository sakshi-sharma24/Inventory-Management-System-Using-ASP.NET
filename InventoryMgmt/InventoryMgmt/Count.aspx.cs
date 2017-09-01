using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryMgmt
{
    public partial class Count : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          HttpContext.Current.Session["Submit"] = textcount.Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Submit"] = textcount.Text;

            Response.Redirect("DisplayCart.aspx");
        }
    }
}