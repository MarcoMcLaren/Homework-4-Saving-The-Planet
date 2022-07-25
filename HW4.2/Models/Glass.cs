using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW4._2.Models
{
    public class Glass : Basic
    {
        public int BeerBottlesAmount { get; set; }
        public int WineBottlesAmount { get; set; }
        public Glass(int beerBottlesAmount, int wineBottlesAmount, int weight, Month recycleMonth)
        {
            BeerBottlesAmount = beerBottlesAmount;
            WineBottlesAmount = wineBottlesAmount;
        }
    }
}