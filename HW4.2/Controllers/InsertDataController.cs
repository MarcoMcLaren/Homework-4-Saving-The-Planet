using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using HW4._2.Models;

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


        //This is where the data will be send from the Insert Data View
        public ActionResult InsertPaper(int PaperKilograms, string PaperMonth)
        {

            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("Insert into Paper VALUES ('"+PaperKilograms+"', '"+PaperMonth+"') ", myConnection);
                ViewBag.Message = "Success: " + myCommand.ExecuteNonQuery() + " rows were updated";
            }
            catch
            {
                ViewBag.Message = "Please Try Again";
            }
            finally{
                myConnection.Close();
            }

            return RedirectToAction("Paper", "DisplayData"); //Will take you to the Paper view when data is submitted successfully
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

            return RedirectToAction("Plastic", "DisplayData"); ; //Will take you to the Paper view when data is submitted successfully
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

            return RedirectToAction("Aluminum", "DisplayData"); //Will take you to the Paper view when data is submitted successfully
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

            return RedirectToAction("Glass", "DisplayData"); //Will take you to the Paper view when data is submitted successfully
        }
    }
}