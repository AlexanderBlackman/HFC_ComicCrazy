using System;
using System.Collections.Generic;
using System.Linq;

namespace HFC_ComicCrazy
{
    class Program
    {
        static void Main(string[] args)
        {
           // IEnumerable<Comic> mostExpensive =
                var mostExpensive = 
                from comic in Comic.Catalogue
                where Comic.Prices[comic.Issue] > 500m
                orderby -Comic.Prices[comic.Issue]
                select comic;
               

            foreach (Comic comic in mostExpensive)
                Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:c}");

        }
    }
}
