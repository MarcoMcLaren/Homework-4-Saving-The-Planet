using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4._2.Models
{
    public class Aluminium : Basic
    {
        public int AmountOfCans { get; set; }

        public Aluminium(int amountOfCans, int Weight, Month RecycleMonth)
        {
            AmountOfCans = amountOfCans;
        }
    }
}