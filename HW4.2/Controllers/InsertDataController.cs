using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace HW4._2.Controllers
{
    public class InsertDataController : Controller
    {
        //Establish a connection to database
        private SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);

        // GET: InsertData view is named as Index
        public ActionResult Index()
        {
            return View();
        }

        //Paper view displaying the summarized data typed into the Insert Data view with the 4 columns
        public ActionResult Paper()
        {
            return View();
        }
        //Plastic view displaying the summarized data typed into the Insert Data view with the 4 columns
        public ActionResult Plastic()
        {
            return View();
        }
        //Glass view displaying the summarized data typed into the Insert Data view with the 4 columns
        public ActionResult Glass ()
        {
            return View();
        }
        //Aluminium view displaying the summarized data typed into the Insert Data view with the 4 columns
        public ActionResult Aluminium()
        {
            return View();
        }

        //This is where the data will be send from the Insert Data View
        public ActionResult InsertPaper()
        {
            return View("Paper"); //Will take you to the Paper view when data is submitted successfully
        }
    }
}