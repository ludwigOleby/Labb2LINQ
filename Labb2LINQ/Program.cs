using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Labb2LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using Context context = new Context();

            // DEKLARERAR OBJEKT
            Ämne Ä1 = new Ämne { Namn = "Programmering 1" };
            Ämne Ä2 = new Ämne { Namn = "Programmering 2" };
            Ämne Ä3 = new Ämne { Namn = "Matte" };
            Ämne Ä4 = new Ämne { Namn = "OOP" };

            Klass K1 = new Klass { KlassNamn = "SUT21" };
            Klass K2 = new Klass { KlassNamn = "HTML1337" };

            Student S1 = new Student { StudentNamn = "Ludwig", Klasser = K1 };
            Student S2 = new Student { StudentNamn = "Sara", Klasser = K1 };
            Student S3 = new Student { StudentNamn = "Sam", Klasser = K2 };
            Student S4 = new Student { StudentNamn = "Anna", Klasser = K2 };

            Lärare L1 = new Lärare { LärarNamn = "Anas" };
            Lärare L2 = new Lärare { LärarNamn = "Tobias" };
            Lärare L3 = new Lärare { LärarNamn = "Reidar" };

            LärareÄmne LÄ1 = new LärareÄmne() { LärarID = 1, lärare = L1, ÄmneID = 1, Ämnen = Ä1 };
            LärareÄmne LÄ2 = new LärareÄmne() { LärarID = 1, lärare = L1, ÄmneID = 4, Ämnen = Ä4 };
            LärareÄmne LÄ3 = new LärareÄmne() { LärarID = 2, lärare = L2, ÄmneID = 2, Ämnen = Ä2 };
            LärareÄmne LÄ4 = new LärareÄmne() { LärarID = 3, lärare = L3, ÄmneID = 3, Ämnen = Ä3 };

            StudentÄmne SÄ1 = new StudentÄmne() { StudentID = 1, student = S1, ÄmneID = 1, ämne = Ä1 };
            StudentÄmne SÄ2 = new StudentÄmne() { StudentID = 2, student = S2, ÄmneID = 2, ämne = Ä2 };
            StudentÄmne SÄ3 = new StudentÄmne() { StudentID = 3, student = S3, ÄmneID = 3, ämne = Ä3 };
            StudentÄmne SÄ4 = new StudentÄmne() { StudentID = 4, student = S4, ÄmneID = 4, ämne = Ä4 };

            StudentLärare SL1 = new StudentLärare() { StudentID = 1, student = S1, LärarID = 1, lärare = L1 };
            StudentLärare SL2 = new StudentLärare() { StudentID = 2, student = S2, LärarID = 2, lärare = L2 };
            StudentLärare SL3 = new StudentLärare() { StudentID = 3, student = S3, LärarID = 3, lärare = L3 };
            StudentLärare SL4 = new StudentLärare() { StudentID = 4, student = S4, LärarID = 4, lärare = L3 };

            // LISTOR FÖR METHOD SYNTAX
            IList<Ämne> ämneslista = new List<Ämne>();
            ämneslista.Add(Ä1);
            ämneslista.Add(Ä2);
            ämneslista.Add(Ä3);
            ämneslista.Add(Ä4);

            IList<Klass> klasslista = new List<Klass>();
            klasslista.Add(K1);
            klasslista.Add(K2);

            IList<Student> studentlista = new List<Student>();
            studentlista.Add(S1);
            studentlista.Add(S2);
            studentlista.Add(S3);
            studentlista.Add(S4);

            IList<Lärare> lärarlista = new List<Lärare>();
            lärarlista.Add(L1);
            lärarlista.Add(L2);
            lärarlista.Add(L3);

            IList<StudentÄmne> studentämnelista = new List<StudentÄmne>();
            studentämnelista.Add(SÄ1);
            studentämnelista.Add(SÄ2);
            studentämnelista.Add(SÄ3);
            studentämnelista.Add(SÄ4);

            IList<LärareÄmne> lärarämnelista = new List<LärareÄmne>();
            lärarämnelista.Add(LÄ1);
            lärarämnelista.Add(LÄ2);
            lärarämnelista.Add(LÄ3);
            lärarämnelista.Add(LÄ4);

            IList<StudentLärare> studentlärarlista = new List<StudentLärare>();
            studentlärarlista.Add(SL1);
            studentlärarlista.Add(SL2);
            studentlärarlista.Add(SL3);
            studentlärarlista.Add(SL4);





            //LÄGGER TILL OBJEKT I DB
            //context.Ämnen.Add(Ä1);
            //context.Ämnen.Add(Ä2);
            //context.Ämnen.Add(Ä3);
            //context.Ämnen.Add(Ä4);

            //context.Klasser.Add(K1);
            //context.Klasser.Add(K2);

            //context.student.Add(S1);
            //context.student.Add(S2);
            //context.student.Add(S3);
            //context.student.Add(S4);

            //context.lärare.Add(L1);
            //context.lärare.Add(L2);
            //context.lärare.Add(L3);


            //context.lärareÄmnen.Add(LÄ1);
            //context.lärareÄmnen.Add(LÄ2);
            //context.lärareÄmnen.Add(LÄ3);
            //context.lärareÄmnen.Add(LÄ4);

            //context.studentÄmne.Add(SÄ1);
            //context.studentÄmne.Add(SÄ2);
            //context.studentÄmne.Add(SÄ3);
            //context.studentÄmne.Add(SÄ4);

            //context.Studentgrupp.Add(SL1);
            //context.Studentgrupp.Add(SL2);
            //context.Studentgrupp.Add(SL3);
            //context.Studentgrupp.Add(SL4);

            //context.SaveChanges();

            //Hämta alla lärare som undervisa matte
            IEnumerable<LärareÄmne> mattelärare = lärarämnelista.Where(s => s.ÄmneID == 3).ToList();

            foreach (var item in mattelärare)
            {
                Console.WriteLine("Lärare som undervisar matte:{0} med id {1}",  item.lärare.LärarNamn, item.LärarID);
            }
            Console.WriteLine("******");

            //Hämta alla elever med sina lärare.
            IEnumerable<StudentLärare> studenlärare = studentlärarlista.ToList();
            foreach (var item in studenlärare)
            {
                Console.WriteLine($"Elevens namn: {item.student.StudentNamn} Lärare: {item.lärare.LärarNamn}");
                Console.WriteLine("---------");
            }
            Console.WriteLine("******");

            //Kolla om ämnen tabell Contains programmering1 eller inte.
            var exist = ämneslista.Contains(Ä1);
            Console.WriteLine("Finns Programmering 1 i ämnestabellen?");
            Console.WriteLine(exist);
            Console.WriteLine("******");


            //Editera en Ämne från programmering2 till OOP
            IEnumerable<Ämne> ersätt = ämneslista.Where(x => x.Namn == "Programmering 2").ToList();
            foreach (var item in ämneslista)
            {
                if (item.Namn == "Programmering 2")
                {
                    item.Namn = "OOP";
                }
                Console.WriteLine(item.Namn);
            }
            Console.WriteLine("******");

            //Uppdatera en student record om sin lärare är Anas till Reidar.
            IEnumerable<StudentLärare> updLärare = studentlärarlista.Where(x => x.lärare.LärarNamn == "Anas").ToList();
            foreach (var item in studentlärarlista)
            {
                if (item.lärare.LärarNamn == "Anas")
                {
                    item.lärare.LärarNamn = "Reidar";
                }
                Console.WriteLine($"Elevens namn: {item.student.StudentNamn} Lärarens namn: {item.lärare.LärarNamn}");
            }
        }
    }
}
