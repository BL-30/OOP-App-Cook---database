using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace DM_BDD
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Client A = new Client("BRUNNER", "Nicolas", "0787256709", "Besancon");

            //Client B = CreationClient();


            A.AjouteClientSQL();
            A.AfficheClientSQL();

            Console.ReadKey();
        }
    }
}
