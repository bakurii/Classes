using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

/** 
   Muista kommentoida toiminnalliset funktiot!
**/
namespace Elaimet
{
    class Program
    {
        //Touhutaan aliohjelmilla.
        public static int IkaTesti(int ikaKissa, int ikaKoira)//aliohjelma testaamaan kumpi elukka on vanhempi.
        {
            
            if(ikaKoira < ikaKissa)
            {
                Console.WriteLine("Kissa on vanhempi kuin koira.");
            }

            else if(ikaKoira > ikaKissa)
            {
                Console.WriteLine("Koira on vanhempi kuin kissa.");
            }

            else
            {
                Console.WriteLine("Molemmat ovat saman ikäisiä.");
            }

            return 0;
        }
            
        static void Main()
        {
            //aliohjelma kutsu
            int testi;

            Random rnd = new Random();
            int luku, luku2;

            //silmukka
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Kissa kisu = new Kissa();//luodaan olio kisu, joka testi osiossa tulostaa ikä lauseen palautuessaan.
                Koira koiro = new Koira();//luodaan olio koiro, joka testi osiossa tulostaa ikä laluseen palautuessaan.
                luku = rnd.Next(1, 10);
                kisu.Ika = luku;

                luku2 = rnd.Next(1, 15);
                koiro.Ika = luku2;
                testi = IkaTesti(kisu.Ika, koiro.Ika);
            }

            Console.ReadKey();
        }
    }
}
