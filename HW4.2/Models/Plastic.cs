using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4._2.Models
{
    public class Plastic : Basic
    { 
        public int AmountOfBottles { get; set; }

        public Plastic(int amountOfBottles, int Weight, Month RecycleMonth)
        {
            AmountOfBottles = amountOfBottles;
        }
    }
}