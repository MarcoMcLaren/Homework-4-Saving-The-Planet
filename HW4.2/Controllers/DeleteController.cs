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
                SqlCommand myCommand = new SqlCommand("DELETE from Paper WHERE ID =" + ID, myConnection);
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
            return RedirectToAction("Paper", "DisplayData");
        }
        ////////////////////////////////////////////////////////////////
        public ActionResult DeletePlastic(int ID)
        {
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("DELETE from Plastic WHERE ID =" + ID, myConnection);
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
            return RedirectToAction("Plastic", "DisplayData");
        }


        ////////////////////////////////////////////////////////////////
        public ActionResult DeleteGlass(int ID)
        {
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("DELETE from Glass WHERE ID =" + ID, myConnection);
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
            return RedirectToAction("Glass", "DisplayData");
        }


        ////////////////////////////////////////////////////////////////
        public ActionResult DeleteAluminum(int ID)
        {
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("DELETE from Aluminum WHERE ID =" + ID, myConnection);
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
            return RedirectToAction("Aluminum", "DisplayData");
        }

        ////////////////////////////////////////////////////////////////

    }
}