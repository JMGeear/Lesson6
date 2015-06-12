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

        protected void grdDepartments_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //store which row was clicked
            Int32 selectedRow = e.RowIndex;

            //get the select student ID using the grids data key collection
            Int32 DepartmentID = Convert.ToInt32(grdDepartments.DataKeys[selectedRow].Values["DepartmentID"]);

            //connect to EF to remove student from db
            using (comp2007Entities db = new comp2007Entities())
            {
                Department d = (from objs in db.Departments
                                where objs.DepartmentID == DepartmentID
                                select objs).FirstOrDefault();

                //Delete
                db.Departments.Remove(d);
                db.SaveChanges();
            }

            // refresh the grid
            GetDepartments();
        }

        protected void grdDepartments_Sorting(object sender, GridViewSortEventArgs e)
        {
            using (comp2007Entities db = new comp2007Entities())
            {


            }
        }

    }

}