using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4._2.Controllers
{
    public class DeleteController : Controller
    {
        private SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
        // GET: Delete
        public ActionResult DeletePaper(int ID)
        {
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("DELETE from Paper WHERE Weight='"+ID+"'", myConnection);
                myCommand.ExecuteNonQuery();
                ViewBag.Message = "Record Deleted";
            }
            catch
            {
                ViewBag.Message = "Error";
                
            }
            finally
            {
                myConnection.Close();
            }
            return RedirectToAction("Paper");
        }
    }
}