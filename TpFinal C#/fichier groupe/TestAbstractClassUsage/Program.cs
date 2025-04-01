using AbstractClassUsage;
using SingletonLibrary;
using System;
using System.Data;

namespace TestAbstractClassUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person e1 = new Employee();
                e1.Id = 6;
                e1.FirstName = "Enock";
                e1.LastName = "Lukonge";
                ((Employee)e1).Cnss = "23LIAGELJ1070590";
               
                e1.Ajouter(e1);
                Console.WriteLine("Employee  enregistrer avec succes!");

                Person e2 = new Employee();
                e2.Id = 7;
                e2.FirstName = "Houlda";
                e2.LastName = "Lukoo";
                ((Employee)e2).Cnss = "22LSILJ650196";

                e2.Ajouter(e2);
                Console.WriteLine("Employee  enregistrer avec succes!");


                Person e3 = new Employee();
                e3.Id = 8;
                e3.FirstName = "Zoe";
                e3.LastName = "Lumela";
                ((Employee)e3).Cnss = "22LSILJ690209";

                e3.Ajouter(e3);
                Console.WriteLine("Employee  enregistrer avec succes!");


                Person e4 = new Employee();
                e4.Id = 9;
                e4.FirstName = "Tony";
                e4.LastName = "Lusambo";
                ((Employee)e4).Cnss = "25LSILJ1072103";

                e4.Ajouter(e4);
                Console.WriteLine("Employee  enregistrer avec succes!");

                Person e5 = new Employee();
                e5.Id = 10;
                e5.FirstName = "Anna";
                e5.LastName = "Lutonde";
                ((Employee)e5).Cnss = "23LIAGELJ1070831";

                e5.Ajouter(e5);
                Console.WriteLine("Employee  enregistrer avec succes!");
              

                Person s1 = new Student(6, "Maki", "Martin", "22LSILJ870225");
                s1.Ajouter(s1);
                Console.WriteLine("Student inserer avec succes!");

                Person s2 = new Student(7, "Masu", "Cedrick", "21IGGJ269705");
                s2.Ajouter(s2);

                Console.WriteLine("Student inserer avec succes!");

                Person s3 = new Student(8, "Madjunga", "Samuel", "25LSILJ1072415");
                s3.Ajouter(s3);

                Console.WriteLine("Student inserer avec succes!");

                Person s4 = new Student(9, "Mafuta", "Enock", "22LSILJ620100");
                s4.Ajouter(s4);

                Console.WriteLine("Student inserer avec succes!");

                Person s5 = new Student(10, "Mangbat", "Baudouin", "22LSILJ620056");
                s5.Ajouter(s5);

                Console.WriteLine("Student inserer avec succes!");
                
                Console.WriteLine("LISTES ETUDIANTS");
                Console.WriteLine("-----------------------------------------");

                e1.VisualiserDonnesIdentite(e1.Id);
                Console.WriteLine("-----------------------------------------");
                e2.VisualiserDonnesIdentite(e2.Id);
                Console.WriteLine("-----------------------------------------");
                e3.VisualiserDonnesIdentite(e3.Id);
                Console.WriteLine("-----------------------------------------");
                e4.VisualiserDonnesIdentite(e4.Id);
                Console.WriteLine("-----------------------------------------");
                e5.VisualiserDonnesIdentite(e5.Id);
                Console.WriteLine("-----------------------------------------");

                s1.VisualiserDonnesIdentite(s1.Id);
                Console.WriteLine("------------------------------------------");
                s2.VisualiserDonnesIdentite(s2.Id);
                Console.WriteLine("-----------------------------------------");
                s3.VisualiserDonnesIdentite(s3.Id);
                Console.WriteLine("-----------------------------------------");
                 s4.VisualiserDonnesIdentite(s4.Id);
                Console.WriteLine("-----------------------------------------");
                s5.VisualiserDonnesIdentite(s5.Id);
                Console.WriteLine("-----------------------------------------");


            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Failed to insert records to the Database, " + ex.Message);
            }
          
            catch (Exception ex)
            {
                Console.WriteLine("Failed to insert records to the Database, " + ex.Message);
            }
            finally
            {
                if (ConnectionFactory.getConnection(ConnectionType.MYSQL_CONNECTION) != null)
                {
                    if (ConnectionFactory.getConnection(ConnectionType.MYSQL_CONNECTION).State == ConnectionState.Open)
                        ConnectionFactory.getConnection(ConnectionType.MYSQL_CONNECTION).Close();
                }

                if (ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION) != null)
                {
                    if (ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).State == ConnectionState.Open)
                        ConnectionFactory.getConnection(ConnectionType.SQL_SERVER_CONNECTION).Close();
                }
            }
            Console.ReadLine();
        }
    }
}
