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
                SqlCommand myCommand = new SqlCommand("SELECT KG, Month from Paper", myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                Globals.BasicList.Clear();
                while (myReader.Read())
                {
                    Basic basic = new Basic();
                    basic.Weight = (int)myReader["KG"];
                    basic.RecycleMonth = (Month)myReader["Month"];
                    Globals.BasicList.Add(basic);
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

            return View(Globals.BasicList) ; //Will take you to the Paper view when data is submitted successfully
        }
    }
    
}