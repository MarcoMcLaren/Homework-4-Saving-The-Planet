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
        public ActionResult InsertPaper(int PaperKilograms, string PaperMonth)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("Insert into Paper VALUES ('"+PaperKilograms+"', '"+PaperMonth+"') ", myConnection);
                myConnection.Open();
                ViewBag.Message = "Success: " + myCommand.ExecuteNonQuery() + " rows were updated";
            }
            catch
            {
                ViewBag.Message = "Please Try Again";
            }
            finally{
                myConnection.Close();
            }

            return View("Index"); //Will take you to the Paper view when data is submitted successfully
        }

        public ActionResult InsertPlastic(int PlasticKilograms, string PlasticMonth, int bottlesAmount)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("Insert into Plastic VALUES ('" + PlasticKilograms + "', '" + PlasticMonth + "', '" + bottlesAmount + "') ", myConnection);
                myConnection.Open();
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

            return View("Index"); //Will take you to the Paper view when data is submitted successfully
        }

        public ActionResult InsertAluminium(int AluminiumKilograms, string AluminiumMonth, int CansAmount)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("Insert into Aluminum VALUES ('" + AluminiumKilograms + "', '" + AluminiumMonth + "', '" + CansAmount + "') ", myConnection);
                myConnection.Open();
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

            return View("Index"); //Will take you to the Paper view when data is submitted successfully
        }

        public ActionResult InsertGlass(int GlassKilograms, string GlassMonth, int BeerBottlesAmount, int WineBottlesAmount)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand("Insert into Glass VALUES ('" + GlassKilograms + "', '" + GlassMonth + "', '" + BeerBottlesAmount + "', '" + WineBottlesAmount + "') ", myConnection);
                myConnection.Open();
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

            return View("Index"); //Will take you to the Paper view when data is submitted successfully
        }
    }
}