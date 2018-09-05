using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string Klassenavn { get; set; }
        public List<Studerende> Klasseliste = new List<Studerende>();
        public DateTime SemesterStart { get; set; }
        public Studerende Studerende { get; set; }

        public int CountVinter { get; set; }
        public int CountForår { get; set; }
        public int CountSommer { get; set; }
        public int CountEfterår { get; set; }

        public KlasseRum()
        {
            
        }
        public void optælling()
        {
            string count = CountVinter.ToString();
            string count2 = CountForår.ToString();
            string count3 = CountSommer.ToString();
            string count4 = CountEfterår.ToString();
            CountVinter = Klasseliste.Count(x => x.årstid == "Vinter");
            CountForår = Klasseliste.Count(x => x.årstid == "Forår");
            CountSommer = Klasseliste.Count(x => x.årstid == "Sommer");
            CountEfterår = Klasseliste.Count(x => x.årstid == "Efterår");


        }

    }
}
