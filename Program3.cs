using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dz_zadatak3
{
    class Program
    {
        
    


        static void Main(string[] args)
        {

            int[] listaDZ = new [] { 3, 5, 8, 9, 9, 4, 3, 4, 5, 2, 1, 2, 4, 5 };

           
            

            string[] stringovi1 = (from num in listaDZ.OrderBy(a => a)
                            group num by num into g
                            select new { number = g.Key, Occurance = g.Count() }).ToArray().OfType<object>().Select(o => o.ToString()).ToArray();

            for(int i = 0; i < stringovi1.Count(); i++)
            {
                Console.WriteLine(stringovi1[i]);

            }
            Console.Read();

        }
    }
}
