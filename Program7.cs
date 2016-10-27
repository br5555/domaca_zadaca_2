using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2zadatak7
{
    class Program
    {
        public class SumaFaktorijela
        {
            public async void Pocetak(int n)
            {
                int faktroijel = await Fatktoriel(n);
                int x = await SumFaktorijela(faktroijel);
                Console.WriteLine(x);
            }

           

            public async Task<int> SumFaktorijela(int n)
            {
                if (n < 10)
                {
                    return n;
                }
                else
                {
                    return (n % 10) + await SumFaktorijela(n / 10);
                }
            }

            public async Task<int> Fatktoriel(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else if (n == 0)
                {
                    return 1;
                }
                else if (n > 1)
                {
                    return n * await Fatktoriel(n - 1);
                }
                else
                {
                    throw new NegativNumeberException();
                }
            }

        }



        static void  Main(string[] args)
        {
            SumaFaktorijela ukupno = new SumaFaktorijela();

            ukupno.Pocetak(4);
            Console.Read();
        }
    }
}
