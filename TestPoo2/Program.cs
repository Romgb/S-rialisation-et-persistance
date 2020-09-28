using System;
using System.Collections.Generic;
using System.IO;
// using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poo3;

namespace TestPoo2
{
    class Program
    {

        
        
        static void Main(string[] args)
        {
           //TesterCollection();
           newFile(@"C:\Windows\Temp\Mytest.txt");
           newAffichage(@"C:\Windows\Temp\Mytest.txt");
           Console.Read();

        }

        static void newFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs,System.Text.Encoding.UTF8);
            string strLine;
            string strLine2;
            strLine = "Coucou";
            strLine2 = "sALUT";
            sw.WriteLine(strLine, strLine2);
            sw.Close();
            fs.Close();  
        }

        static void newAffichage(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8);
            string strLine;
           
            while ((strLine = sr.ReadLine()) != null)
            {
               Console.WriteLine(strLine);
            }
            fs.Close();
            sr.Close();           
        }



        static void Polymorphe1()
        {
            Salarie sal1 = new Salarie("Bost", "Vincent", "96AAA11");

            Commercial com1 = new Commercial("Bost", "Vincent", "96AAA11", 10000, 0.10m)
            {
                SalaireBrut = 3500.00m,
                TauxCS = 0.35m
            };

            Console.WriteLine("Salaire commercial attendu {0} obtenu {1} assertion {2} ", 3275, com1.SalaireNet, 3275 == com1.SalaireNet);
            Console.WriteLine("Détails : {0}", com1.ToString());
            Console.ReadLine();
        }
        static void TesterCollection()
        {

            Salaries salaries = new Salaries();
            salaries.Add(new Salarie() { Matricule = "01tre12", Nom = "bost", Prenom = "Vincent", DateNaissance = new DateTime(1962, 01, 13) });
            salaries.Add(new Salarie()
                {
                    Matricule = "01tre13",
                    Nom = "bosti",
                    Prenom = "Vincente",
                    DateNaissance = new DateTime(1962, 01, 14)
                });
            Salarie sal3 = new Salarie()
            {
                Matricule = "01tre13",
                Nom = "bosti",
                Prenom = "Vincente",
                DateNaissance = new DateTime(1962, 01, 14)

            };
            salaries.Add(sal3);
           
            

            Console.ReadLine();
           
            
        }

    }
}