using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4._2.Models
{
    public class Plastic : Paper
    {
        public new int ID { get; set; }
        public int AmountOfBottles { get; set; }
    }
   
}