using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryMgmt
{
    public partial class DisplayCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = $"Item Name-: {HttpContext.Current.Session["Name"]}";
            Label2.Text = $"Cost-: {HttpContext.Current.Session["Cost"]}";
            Label3.Text = $"Item Count-: {HttpContext.Current.Session["Submit"]}";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            Response.Redirect("~/Message.aspx");
            
           
        }
    }
}