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
            try
            {
            KlasseRum klasse = new KlasseRum();

            Studerende Kevin = new Studerende("Kevin",1,1);
            Studerende Sæve = new Studerende("Sebastian",5,5);
            Studerende Michael = new Studerende("Michael", 9, 9);
            //Studerende Michaels = new Studerende("Michael", 13, 13);


            klasse.Klasseliste.Add(Kevin);
            klasse.Klasseliste.Add(Sæve);
            klasse.Klasseliste.Add(Michael);
            //klasse.Klasseliste.Add(Michaels);
        

            klasse.Klassenavn = "3B";
            klasse.SemesterStart = DateTime.Parse("4-9-2018");
           
            klasse.optælling();

            foreach (var studerende in klasse.Klasseliste)
            {
                Console.WriteLine(studerende.Navn+" "+ studerende.årstid);
                //Console.WriteLine(studerende.årstid);
                
            }
            Console.WriteLine("Vinter:"+klasse.CountVinter);
            Console.WriteLine("Forår:"+klasse.CountForår);
            Console.WriteLine("Sommer:"+klasse.CountSommer);
            Console.WriteLine("Efterår:"+klasse.CountEfterår);
            Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           




        }

    }
}
