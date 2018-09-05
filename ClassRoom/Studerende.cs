using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        private int _fødselsmåned;

        public string Navn { get; set; }
        public int Fødselsmåned { get => _fødselsmåned; set => _fødselsmåned = value ; }
        public int Fødselsdag { get; set; }
        public string årstid { get; set; }


        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
            Årstid();
            if (fødselsmåned<=0 || fødselsmåned >=13)
            {
                throw new System.Exception("Fødselsdags måned er udenfor index");
            }

        }



        public string Årstid()
        {


            if (Fødselsmåned == 12 || Fødselsmåned == 1 || Fødselsmåned == 2)
            {
                årstid = "Vinter";
            }
            else if (Fødselsmåned == 3 || Fødselsmåned == 4 || Fødselsmåned == 5)
            {
                årstid = "Forår";
            }
            else if (Fødselsmåned == 6 || Fødselsmåned == 7 || Fødselsmåned == 8)
            {
                årstid = "Sommer";
            }
            else if (Fødselsmåned == 9 || Fødselsmåned == 10 || Fødselsmåned == 11)
            {
                årstid = "Efterår";
            }
            
            return årstid;




        }
    }
}
