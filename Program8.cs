using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_zadatak8
{
    class Program
    {
        public class SumaFaktorijela
        {
            public async Task<int> Pocetak(int n)
            {
                int faktroijel =  await Fatktoriel(n);
                return await SumFaktorijela(faktroijel);
            }

            public async Task<int> SumFaktorijela(int n)
            {
                if (n < 10)
                {
                    return  n;
                }
                else
                {
                    return  (n % 10) + await SumFaktorijela(n / 10);
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
                    return  n * await Fatktoriel(n - 1);
                }
                else
                {
                    throw new NegativNumeberException();
                }
            }

        }

        static void Main(string[] args)
        {
            //Main method is the only method that 
            //can't be marked with async
            //What we are doing here is just a way for us to simulate
            //async-friendly enviroment you usually have with
            //other .NET applications types (like web apps,  win apps etc.)
            //Ignore main method, you can just focus on
            //LetsSayUserClickedAButtonOnGuiMethod() as a 
            //first method in call hierarchy
            var t = Task.Run(() => LetsSayUserClickedAButtonOnGuiMethod());

            Console.Read();
        }


        private static async void LetsSayUserClickedAButtonOnGuiMethod()
        {
            var result = await GetTheMagicNumber();
            Console.WriteLine(result);
        }

        private static async Task<int> GetTheMagicNumber()
        {
            return await IKnowIGuyWhoKnowsAGuy();
        }

        private static async Task<int> IKnowIGuyWhoKnowsAGuy()
        {
            return await IKnowWhoKnowsThis(10) + await IKnowWhoKnowsThis(5);
        }
        private static async Task<int> IKnowWhoKnowsThis(int n)
        {
            SumaFaktorijela t = new SumaFaktorijela();
            return await t.Pocetak(n);
        }
    }
}
