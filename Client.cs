using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace DM_BDD
{
    class Client
    {
        protected int id;
        protected string nom;
        protected string prenom;
        protected string numeroDeTelephone;
        protected string adresse;

        public Client(int Id, string Nom, string Prenom, string NumeroDeTel, string Adresse)
        {
            this.id = Id;
            this.nom = Nom;
            this.prenom = Prenom;
            this.numeroDeTelephone = NumeroDeTel;
            this.adresse = Adresse;
        }

        #region Constructeurs

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }
            set
            {
                this.prenom = value;
            }
        }

        public string NumeroDeTelephone
        {
            get
            {
                return this.numeroDeTelephone;
            }
            set
            {
                this.numeroDeTelephone = value;
            }
        }

        public string Adresse
        {
            get
            {
                return this.adresse;
            }
            set
            {
                this.adresse = value;
            }
        }


        #endregion

        public void AfficheClientSQL()
        {
            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=societe_cooking;UID=root;PASSWORD=Nic0las1999!Afipam3901;SSLMODE=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM client;";

            MySqlDataReader reader;
            reader = command.ExecuteReader();



            while (reader.Read())
            {

                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string valueAsString = reader.GetValue(i).ToString();
                    currentRowAsString += valueAsString + ",";
                }
                Console.WriteLine(currentRowAsString);

            }
            connection.Close();

        }

        public void AjouteClientSQL()
        {
            string nom;
            string prenom;
            string numTel;
            string adresse;

            Console.WriteLine("Saisir nom : ");
            nom = Console.ReadLine();

            Console.WriteLine("Saisir prenom : ");
            prenom = Console.ReadLine();

            Console.WriteLine("Saisir numéro tel : ");
            numTel = Console.ReadLine();

            Console.WriteLine("Saisir adresse : ");
            adresse = Console.ReadLine();



            string connectionString = "SERVER=localhost;PORT=3306;DATABASE=societe_cooking;UID=root;PASSWORD=Nic0las1999!Afipam3901;SSLMODE=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO `societe_cooking`.`client` (`nom_client`,`numTel_client`, `adresse_client`) VALUES ('" + nom + " " + prenom + "' ,'" + numTel + "','" + adresse + "');";

            MySqlDataReader reader;
            reader = command.ExecuteReader();



            while (reader.Read())
            {

                string currentRowAsString = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string valueAsString = reader.GetValue(i).ToString();
                    currentRowAsString += valueAsString + ",";
                }
                Console.WriteLine(currentRowAsString);

            }

            connection.Close();

        }
    }
}
