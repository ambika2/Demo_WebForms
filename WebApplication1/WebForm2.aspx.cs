using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // this.nameLabel.Text=string.Format("Hi {0}", this.PreviousPage.UserName);
            if(this.PreviousPage!=null)
            this.nameLabel.Text=$"Hi {this.PreviousPage.UserName}";
            else
            {
                Response.Redirect("~/Page1.aspx");
            }
        }
    }
}