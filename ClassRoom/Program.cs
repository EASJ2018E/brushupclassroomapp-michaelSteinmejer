using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasse = new KlasseRum();

            Studerende Kevin = new Studerende("Kevin",8,8);
            Studerende Sæve = new Studerende("Sebastian",7,7);
            Studerende Michael = new Studerende("Michael", 6, 6);


            klasse.Klasseliste.Add(Kevin);
            klasse.Klasseliste.Add(Sæve);
            klasse.Klasseliste.Add(Michael);

            klasse.Klassenavn = "3B";
            klasse.SemesterStart = new DateTime(4-9-2018);

        }
    }
}
