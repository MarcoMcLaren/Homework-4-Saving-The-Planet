using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using HW4._2.Models;

namespace HW4._2.Controllers
{
    public class UpdateController : Controller
    {
        private SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
        // GET: Update
        public ActionResult UpdatePaper(int ID, int PaperKilograms, string PaperMonth)
        {
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("UPDATE Paper SET ('" + PaperKilograms + "', '" + PaperMonth + "')WHERE ID="+ID, myConnection);
                ViewBag.Message = "Success: " + myCommand.ExecuteNonQuery() + " rows were updated";
            }
            catch
            {
                ViewBag.Message = "Please Try Again";
            }
            finally
            {
                myConnection.Close();
            }

            return RedirectToAction("Paper", "DisplayData"); //Will take you to the Paper view when data is submitted successfully
        }
        
        /////////////////////////////////////////////////////////////////////////////////
       
        public ActionResult UpdatePlastic()
        {
            return View();
        }
        /////////////////////////////////////////////////////////////////////////////////
        public ActionResult UpdateGlass()
        {
            return View();
        }
        /////////////////////////////////////////////////////////////////////////////////
        public ActionResult UpdateAluminum()
        {
            return View();
        }
    }
}