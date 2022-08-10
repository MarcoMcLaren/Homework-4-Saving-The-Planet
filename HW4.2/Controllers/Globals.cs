using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW4._2.Models;

namespace HW4._2.Controllers
{
    public static class Globals
    {
        //Establish connection to database
        public static string ConnectionString = "Data Source=MARCO_LAPTOP;Initial Catalog=SaveTheWorld;Integrated Security=True";
        //Please note this is connected to MARCO_LAPTOP, if you wish to run it on your own computer you will have to change the path

        //PC connection
        //public static string ConnectionString = "Data Source=MARCO_PC;Initial Catalog=SaveTheWorld;Integrated Security=True";

        //Create all the lists from their respective models
        public static List<Paper> PaperList = new List<Paper>();
        public static List<Plastic> PlasticList = new List<Plastic>();
        public static List<Glass> GlassList = new List<Glass>();
        public static List<Aluminum> AluminumList = new List<Aluminum>();

    }
}