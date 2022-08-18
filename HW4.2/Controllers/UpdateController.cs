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
        //Establish a connection to database
        private SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
        // GET: Update
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UpdatePaper(int ID, int PaperKilograms)
        {

            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("UPDATE Paper SET KG = '" + PaperKilograms + "' WHERE ID='"+ID+"' ", myConnection);
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

        public ActionResult UpdatePlastic(int ID, int PlasticKilograms, int bottlesAmount)
        {

            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("UPDATE Plastic SET KG = '" + PlasticKilograms + "', Bottles_Amount = '" + bottlesAmount + "' WHERE ID='" + ID + "' ", myConnection);
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

            return RedirectToAction("Plastic", "DisplayData"); //Will take you to the Paper view when data is submitted successfully
        }

        public ActionResult UpdateGlass(int ID, int GlassKilograms, int BeerBottlesAmount, int WineBottlesAmount)
        {

            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("UPDATE Glass SET KG = '" + GlassKilograms + "', BeerBottles = '"+ BeerBottlesAmount +"', WineBottles = '"+WineBottlesAmount+"' WHERE ID='" + ID + "' ", myConnection);
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

        public ActionResult UpdateAluminum(int ID, int AluminumKilograms, int CansAmount)
        {

            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("UPDATE Aluminum SET KG = '" + AluminumKilograms + "', Cans = '"+ CansAmount + "' WHERE ID='" + ID + "' ", myConnection);
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
    }
}