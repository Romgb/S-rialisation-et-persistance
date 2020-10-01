using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
// using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Poo3;

namespace TestPoo2
{
    class Program
    {
        static Salaries salaries = new Salaries();
        static void Main(string[] args)
        {
            //Conversion Json
            //Salarie sal3 = new Salarie("Grotte", "Pascal", "63CCC17");


            //sal3.ChangementSalaire += new Salarie.ChangementSalaireEventHandler(Salarie_ChangementSalaire);
            // sal3.ChangementSalaire += Salarie_ChangementSalaire;

            //string conv = JsonConvert.SerializeObject(sal3);


            // Creation des salaries de la classe Salarie
            // Salarie sal1 = new Salarie("Bost", "Vincent", "96AAA11");
            // Salarie sal2 = new Salarie("Breguet", "Aline", "74BBB56");

            // TesterCollection()
            // newFile(@"C:\Windows\Temp\Mytest.txt");
            // newAffichage(@"C:\Windows\Temp\Mytest.txt");

            // Méthode csv
            // SaveText(@"C:\Windows\Temp\Salaries.csv", sal1);
            // newSalarieAffichage(@"C:\Windows\Temp\Salaries.csv", sal1);

            // SavecCom(@"C:\Windows\Temp\Mytest.txt", com1);

            // Méthode XML
            // SauvegardeXML(@"C:\Windows\Temp\Sauvegarde.Xml", sal2);
            // LoadXml(@"C:\Windows\Temp\Sauvegarde.Xml");

            // Méthode Json
            // SaveJson(@"C:\Windows\Temp\ConvJson.txt", sal2);
            // Loadjson(@"C:\Windows\Temp\ConvJson.txt");

            // ChargeSal(@"C:\Windows\Temp\Salaries.csv", sal1);
            // Salarie s1 = LoadSalarie(@"C:\Windows\Temp\Salaries.csv");

            //Console.WriteLine(s1.ToString());

            //Console.WriteLine(LoadJson(@"C:\Windows\Temp\ConvJson.txt"));
            //Console.Read();
            
            //Salarie salarie3 = new Salarie { Nom = "Grotte", Prenom = "Pascal", Matricule = "63CCC17" };
            //AddSalarie(salarie3);

            

            //salarie3 = new Salarie { Nom = "Grobbe", Prenom = "Didier", Matricule = "63CCE17" };
            //AddSalarie(salarie3);

            //salarie3 = new Salarie { Nom = "Grosse", Prenom = "Pascal", Matricule = "63CCC17" };
            //AddSalarie(salarie3);

            Salarie salarie3 = new Salarie { Nom = "Grobbe", Prenom = "Didier", Matricule = "63CCC17" };
            AddSalarie(salarie3);

            salarie3 = new Salarie { Nom = "Grossss", Prenom = "Didier", Matricule = "63AAA17" };
            AddSalarie(salarie3);

            salarie3 = new Salarie { Nom = "Grobbe", Prenom = "Didier", Matricule = "63AAA17" };
            AddSalarie(salarie3);

            salarie3 = new Salarie { Nom = "Grobi", Prenom = "Didi", Matricule = "63AAA17" };
            AddSalarie(salarie3); 

            salarie3 = new Salarie { Nom = "Grobbe" };
            AddSalarie(salarie3); 
            
            salarie3 = new Salarie {Matricule = "63AAA17" };
            AddSalarie(salarie3);

            salarie3 = new Salarie { Nom = "Grobi", Prenom = "Didi", Matricule = "63AAA18" };
            AddSalarie(salarie3);


            Console.Read();
        }

        private static void AddSalarie(Salarie sal)
        {
            bool ok = false;
            try
            {
                salaries.AddV2(sal);
                Console.WriteLine("Le salarié vient d'être créé");
                ok = true;

                if (sal.Matricule == null || sal.Nom == string.Empty || sal.Prenom == null )
                {

                    throw new ArgumentException("Un des champs n'est pas rempli");
                    ok = false;

                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Un des champs n'est pas rempli");
                ok = false;

            }
            catch (ApplicationException)
            {
                Console.WriteLine("Ce salarié existe déjà");
                ok = false;                
            }
            catch (Exception)
            {
                Console.WriteLine("Ce salarié existe déjà");
                ok = false;
            }
            
            finally
            {
                Console.WriteLine(ok);
            }
        }

        public static void Salarie_ChangementSalaire(object sender, ChangementSalaireEventArgs e)
        {
            Console.WriteLine(string.Format("Votre salaire est passé de {0} à {1}", e.AncienSalaire, e.NouveauSalaire));
        }

        #region Méthode SaveText()
        static void SaveText(string path, Salarie sal1)
        {

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            sw.WriteLine(sal1.ToString());
            sw.Close();
            fs.Close();
        }
        static void newSalarieAffichage(string path, Salarie sal1)
        {

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string sal = sal1.ToString();

            while ((sal = sr.ReadLine()) != null)
            {
                Console.WriteLine(sal1);
            }
            fs.Close();
            sr.Close();
        }
        #endregion

        #region Méthode LoadText()
        static void ChargeSal(string path, Salarie sal1)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string words = sr.ReadLine();
            string[] split = words.Split(new char[] { ';' });

            foreach (string s in split)
            {
                if (s.Trim() != "")
                    Console.WriteLine(s);
            }

            fs.Close();
            sr.Close();
        }

        public static Salarie LoadSalarie(string path)
        {

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string words = sr.ReadLine();
            string[] split = words.Split(new char[] { ';' });
            Salarie sala = new Salarie
            {
                Matricule = split[0],
                Nom = split[1],
                Prenom = split[2],
            };

            return sala;
        }

        #endregion

        #region Méthode Binary()

        public void SauvegardeBinary(string path, Salarie sal1)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, sal1);


        }
        #endregion

        #region Méthode XML
        static void SauvegardeXML(string path, Salarie sal2)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            XmlTextWriter xmlTW = new XmlTextWriter(fs, Encoding.UTF8);
            XmlSerializer xmlS = new XmlSerializer(sal2.GetType());
            xmlS.Serialize(xmlTW, sal2);
            fs.Close();
        }
        static void LoadXml(string path)
        {
            using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlSerializer xmlS = new XmlSerializer(typeof(Salarie));
            Salarie sal = xmlS.Deserialize(fs) as Salarie;
        }
        #endregion

        #region Méthode Json
        static void SaveJson(string path, Salarie sal2)
        {
            JsonSerializer szr = new JsonSerializer();
            using StreamWriter sw = new StreamWriter(path);
            using JsonTextWriter jw = new JsonTextWriter(sw);
            {
                szr.Serialize(jw, sal2);
            }
        }
        //static void Loadjson(string path)
        //{
        //    JsonSerializer szr = new JsonSerializer();
        //    using StreamReader sr = new StreamReader(path);
        //    using JsonReader tr = new JsonTextReader(sr);
        //    Salarie sal = szr.Deserialize(tr) as Salarie;
        //    sr.Close();


        //}
        static JObject LoadJson(string path)
        {
            JObject obj = null;
            JsonSerializer szr = new JsonSerializer();
            using StreamReader sr = new StreamReader(path);
            using JsonReader tr = new JsonTextReader(sr);
            obj = szr.Deserialize(tr) as JObject;
            sr.Close();
            return obj;
        }
        #endregion

        #region Affichage objet
        static void newFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            string strLine;
            string strLine2;
            strLine = "Coucou";
            strLine2 = "salut";
            sw.WriteLine(strLine);
            sw.WriteLine(strLine2);
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

        #endregion

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
