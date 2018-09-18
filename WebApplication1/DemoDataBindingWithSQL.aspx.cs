using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DemoDataBindingWithSQL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (NorthWindDataSetDataContext dbContext = new NorthWindDataSetDataContext())
            {
                var query = from emp in dbContext.Employees
                            select new
                            {
                                emp.EmployeeID,
                                emp.FirstName,
                                emp.LastName
                            };
                this.GridView1.DataSource = query;
                this.GridView1.DataBind();
            }
        }
    }
}