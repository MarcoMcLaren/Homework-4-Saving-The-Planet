using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using HW4._2.Models;

namespace HW4._2.Controllers
{
    public class DisplayDataController : Controller
    {
        //Establish a connection to database
        private SqlConnection myConnection = new SqlConnection(Globals.ConnectionString);
        public ActionResult Paper()
        {
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("SELECT Paper.ID, Paper.KG, Paper.Month from Paper", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                Globals.PaperList.Clear();
                while (myReader.Read())
                {
                    Paper paper = new Paper();
                    paper.ID = (int)myReader["ID"];
                    paper.Weight = Convert.ToInt16(myReader["KG"]);
                    paper.RecycleMonth = (Month)System.Enum.Parse(typeof(Month), myReader["Month"].ToString());
                    Globals.PaperList.Add(paper);
                }
            }
            catch
            {
                ViewBag.errMessage = "ERROR";
            }
            finally
            {
                myConnection.Close();
            }

            return View(Globals.PaperList); 
        }


        ////////////////////////////////////////////////////////////////////////////
        public ActionResult Plastic()
        {
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("SELECT ID, KG,Month, Bottles_Amount from Plastic", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                Globals.PlasticList.Clear();
                while (myReader.Read())
                {
                    Plastic plastic = new Plastic();
                    plastic.ID = (int)myReader["ID"];
                    plastic.Weight = Convert.ToInt16(myReader["KG"]);
                    plastic.RecycleMonth = (Month)System.Enum.Parse(typeof(Month), myReader["Month"].ToString());
                    plastic.AmountOfBottles = (int)myReader["Bottles_Amount"];
                    Globals.PlasticList.Add(plastic);
                }
            }
            catch
            {
                ViewBag.errMessage = "ERROR";
            }
            finally
            {
                myConnection.Close();
            }

            return View(Globals.PlasticList);
        }

        ////////////////////////////////////////////////////////////////////////////
        public ActionResult Glass()
        {
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("SELECT ID, KG,Month, BeerBottles, WineBottles from Glass", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                Globals.GlassList.Clear();
                while (myReader.Read())
                {
                    Glass glass = new Glass();
                    glass.ID = (int)myReader["ID"];
                    glass.Weight = Convert.ToInt16(myReader["KG"]);
                    glass.RecycleMonth = (Month)System.Enum.Parse(typeof(Month), myReader["Month"].ToString());
                    glass.AmountOfBeerBottles = (int)myReader["BeerBottles"];
                    glass.AmountOfWineBottles = (int)myReader["WineBottles"];
                    Globals.GlassList.Add(glass);
                }
            }
            catch
            {
                ViewBag.errMessage = "ERROR";
            }
            finally
            {
                myConnection.Close();
            }

            return View(Globals.GlassList);
        }

        ////////////////////////////////////////////////////////////////////////////
        public ActionResult Aluminum()
        {
            try
            {
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand("SELECT ID, KG,Month, Cans from Aluminum", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                Globals.AluminumList.Clear();
                while (myReader.Read())
                {
                    Aluminum aluminum = new Aluminum();
                    aluminum.ID = (int)myReader["ID"];
                    aluminum.Weight = Convert.ToInt16(myReader["KG"]);
                    aluminum.RecycleMonth = (Month)System.Enum.Parse(typeof(Month), myReader["Month"].ToString());
                    aluminum.AmountOfCans = (int)myReader["Cans"];
                    Globals.AluminumList.Add(aluminum);
                }
            }
            catch
            {
                ViewBag.errMessage = "ERROR";
            }
            finally
            {
                myConnection.Close();
            }

            return View(Globals.AluminumList);
        }
    }

}