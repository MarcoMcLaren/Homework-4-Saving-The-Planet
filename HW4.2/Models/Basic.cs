using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4._2.Models
{
    //Used for Paper 
    public class Basic //All other classes will inherit from this class
    {
        public int Weight { get; set; }
        public Month RecycleMonth { get; set; }

    }
    //Populate dropdown list
    public enum Month
    {
        January, February, March, April, May, June, July, August, September, October, November, December
    }
}