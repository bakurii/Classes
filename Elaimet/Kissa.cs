using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Kissa
    {
        private String nimi;
        private int ika;
        string uppNimi;

        public Kissa()//Parametriton konstruktori
        {

        }

        public Kissa(String nimi, int ika)//parametrillinen konstruktori. 
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
                if (uppNimi == "HILDA")
                {
                    Console.WriteLine("Hilda missään muodossa ei kelpaa.:(");
                }

                else
                {
                    Console.WriteLine("Kissan uusi nimi: " + nimi);
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
                    Console.WriteLine("Kissan ikä: " + ika);
                }

            }
        }

        public int Ika1 { get => ika; set => ika = value; }//Tehtävä5. kuvavihje.
    }
}
