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
    public partial class department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if save wasnot clicked and we have a student id
            if (!IsPostBack && (Request.QueryString.Count > 0))
            {
                GetDepartment();
            }
        }
        protected void GetDepartment()
        {
            // populate form
            Int32 DepartmentID = Convert.ToInt32(Request.QueryString["DepartmentID"]);
            //Connect
            using (comp2007Entities db = new comp2007Entities())
            {
                Department d = (from objs in db.Departments
                             where objs.DepartmentID == DepartmentID
                             select objs).FirstOrDefault();

                //Map student to controls
                if (d != null)
                {
                    txtDeptName.Text = d.Name;
                    txtBudget.Text = d.Budget.ToString();
                }

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //use EF to connect to SQL Server
            using (comp2007Entities db = new comp2007Entities())
            {

                //use the Student model to save the new record
                Department d = new Department();

                d.Name = txtDeptName.Text;
                d.Budget = Convert.ToDecimal(txtBudget.Text);

                db.Departments.Add(d);
                db.SaveChanges();

                //redirect to the updated students page
                Response.Redirect("departments.aspx");
            }
        }
    }
}