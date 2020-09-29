using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Koira
    {
        private String nimi;
        private int ika;
        string uppNimi;

        public Koira()//Parametriton konstruktori
        {

        }

        public Koira(String nimi, int ika)//parametrillinen konstruktori. 
        {
            this.nimi = nimi;
            this.ika = ika;
        }

        //METODIT
        public String Nimi
        {
            get
            {
                return nimi;
            }

            set
            {
                nimi = value;
                uppNimi = nimi.ToUpper();
                //jos kissalle annetaan nimeksi Hilda, ohjelma palauttaa arvon false.....
                if (uppNimi == "MUSTI")
                {
                    Console.WriteLine("Musti missään muodossa ei kelpaa.:(");
                    Console.WriteLine(nimi);
                }

                else
                {
                    Console.WriteLine("Koiran uusi nimi: " + nimi);
                }

            }
        }

        public int Ika
        {
            get
            {
                return ika;
            }

            set
            {
                ika = value;
                if (ika < 0)//tarkistaa kissan iän, jos luku on negatiivinen!!!!!!!!!!!!!!!niin mihin tän oli tarkoitus tulla??
                {
                    Console.WriteLine("Luku ei saa olla negatiivinen");
                }

                else if (ika >= 0)
                {
                    Console.WriteLine("Koiran ikä: " + ika);
                }

            }

        }
    }
}
