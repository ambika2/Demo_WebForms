using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DemoOfDataBinding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (NorthWindDataSet ds = new NorthWindDataSet())
            {
                using (WebApplication1.NorthWindDataSetTableAdapters.EmployeesTableAdapter taEmployees
                    = new NorthWindDataSetTableAdapters.EmployeesTableAdapter())
                {
                    taEmployees.Fill(ds.Employees);
                    //adapter will take data from database and fill it in our dataset
                    //creating a in memory database as dataset object.

                    //fill our gridview with dataset employees
                    this.GridView1.DataSource = ds.Employees;

                    //populating every record
                    this.GridView1.DataBind();
                }
            }
        }
    }
}