using InterfaceUsage;
using SingletonLibrary;
using System;
using System.Data;

namespace TestInterfaceUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPerson e1 = new Employee();
                ((Employee)e1).Id = 1;
                ((Employee)e1).FirstName = "Enock";
                ((Employee)e1).LastName = "Lukonge";
                ((Employee)e1).Cnss = "23LIAGELJ1070590";


                e1.Ajouter();
                Console.WriteLine("Employee inserer avec succes!");

                IPerson e2 = new Employee();
                ((Employee)e2).Id = 2;
                ((Employee)e2).FirstName = "Houlda";
                ((Employee)e2).LastName = "Lukoo";
                ((Employee)e2).Cnss = "22LSILJ650196";

                e2.Ajouter();
                Console.WriteLine("Employee inserer avec succes!");

                IPerson e3 = new Employee();
                ((Employee)e3).Id = 3;
                ((Employee)e3).FirstName = "Zoe";
                ((Employee)e3).LastName = "Lumela";
                ((Employee)e3).Cnss = "22LSILJ690209";

                e3.Ajouter();
                Console.WriteLine("Employee inserer avec succes!");


                IPerson e4 = new Employee();
                ((Employee)e4).Id = 4;
                ((Employee)e4).FirstName = "Tony";
                ((Employee)e4).LastName = "Lusambo";
                ((Employee)e4).Cnss = "25LSILJ1072103";

                e4.Ajouter();
                Console.WriteLine("Employee inserer avec succes!");

                IPerson e5 = new Employee();
                ((Employee)e5).Id = 5;
                ((Employee)e5).FirstName = "Anna";
                ((Employee)e5).LastName = "Lutonde";
                ((Employee)e5).Cnss = "23LIAGELJ1070831";

                e5.Ajouter();
                Console.WriteLine("Employee inserer avec succes!");

       
                IPerson s1 = new Student(1, "Martin", "Maki", "22LSILJ870225");
                s1.Ajouter();
                Console.WriteLine("Etudiants inserer avec succes!");

                IPerson s2 = new Student(2, "Madjunga", "Samuel", "22LSILJ1072415");
                s2.Ajouter();
                Console.WriteLine("Etudiants inserer avec succes!");

                IPerson s3 = new Student(3, "Mafuta", "Enock", "22LSILJ620100");
                s3.Ajouter();
                Console.WriteLine("Etudiants inserer avec succes!");

                IPerson s4 = new Student(4, "Mangbata", "Baudouin", "22LSILJ620056");
                s4.Ajouter();
                Console.WriteLine("Etudiants inserer avec succes!");

                IPerson s5 = new Student(5, "Masu", "Cedrick", "21IGGJ269705");
                s5.Ajouter();
                Console.WriteLine("Etudiants inserer avec succes!");



                Console.WriteLine("LISTES EMPLOYEES");

                e1.visualiserdonnesIdentite(((Employee)e1).Id);
                Console.WriteLine("-----------------------------------------");
                e2.visualiserdonnesIdentite(((Employee)e2).Id);
                Console.WriteLine("-----------------------------------------");
                e3.visualiserdonnesIdentite(((Employee)e3).Id);
                Console.WriteLine("-----------------------------------------");
                e4.visualiserdonnesIdentite(((Employee)e4).Id);
                Console.WriteLine("-----------------------------------------");
                e5.visualiserdonnesIdentite(((Employee)e5).Id);
                Console.WriteLine("-----------------------------------------");


                Console.WriteLine("LISTES ETUDIANTS");
                s1.visualiserdonnesIdentite(((Student)s1).Id);
                Console.WriteLine("------------------------------------------");
                s2.visualiserdonnesIdentite(((Student)s2).Id);
                Console.WriteLine("------------------------------------------");
                s3.visualiserdonnesIdentite(((Student)s3).Id);
                Console.WriteLine("------------------------------------------");
                s4.visualiserdonnesIdentite(((Student)s4).Id);
                Console.WriteLine("------------------------------------------");
                s5.visualiserdonnesIdentite(((Student)s5).Id);
                Console.WriteLine("------------------------------------------");
               
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
