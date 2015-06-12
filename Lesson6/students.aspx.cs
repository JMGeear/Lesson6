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
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading the page for the first time, populate student grid
            if (!IsPostBack)
            {
                GetStudents();
            }
        }
        protected void GetStudents()
        {
            //connect to EF
            using (comp2007Entities db = new comp2007Entities())
            {

                //query the students table using EF and LINQ
                var Students = from s in db.Students
                               select s;

                //bind the result to the gridview
                grdStudents.DataSource = Students.ToList();
                grdStudents.DataBind();

            }
        }

        protected void grdStudents_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //store which row was clicked
            Int32 selectedRow = e.RowIndex;

            //get the select student ID using the grids data key collection
            Int32 StudentID = Convert.ToInt32(grdStudents.DataKeys[selectedRow].Values["StudentID"]);

            //connect to EF to remove student from db
            using (comp2007Entities db = new comp2007Entities())
            {
                Student s = (from objs in db.Students
                             where objs.StudentID == StudentID
                             select objs).FirstOrDefault();

                //Delete
                db.Students.Remove(s);
                db.SaveChanges();
            }

            // refresh the grid
            GetStudents();
        }

    }
}