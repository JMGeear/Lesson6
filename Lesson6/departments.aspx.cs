using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Lesson6.Models;
using System.Web.ModelBinding;

namespace Lesson6
{
    public partial class departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if loading the page for the first time, populate student grid
            if (!IsPostBack)
            {
                GetDepartments();
            }
        }
        protected void GetDepartments()
        {
            //connect to EF
            using (comp2007Entities db = new comp2007Entities())
            {

                //query the students table using EF and LINQ
                var Departments = from d in db.Departments
                                  select d;

                //bind the result to the gridview
                grdDepartments.DataSource = Departments.ToList();
                grdDepartments.DataBind();

            }
        }
    }
}