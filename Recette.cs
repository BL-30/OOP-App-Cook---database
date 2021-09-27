using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;

namespace DM_BDD
{
    class Recette : Produit
    {
        public string nom_r;
        public string type;
        public List<Produit> liste_prod;
        public string descriptif;
        public int quantite;
        public float prix;
        public float remuneration;
        public int compteur;


        public Recette(string Nom_p, string Categorie, float Stock_a, float Stock_min, float Stock_max, string Nom_f, int Ref_f, int Unite, string Nom_r, string Type, List<Produit> Liste_prod, string Descriptif, int Quantite, float Prix, float Remuneration, int Compteur) : base(Nom_p, Categorie, Stock_a, Stock_min, Stock_max, Nom_f, Ref_f, Unite)
        {
            this.nom_r = Nom_r;
            this.type = Type;
            this.liste_prod = Liste_prod;
            this.descriptif = Descriptif;
            this.quantite = Quantite;
            this.prix = Prix;
            this.remuneration = Remuneration;
            this.compteur = Compteur;
        }

        #region Constructeurs

        public string Nom_r
        {
            get
            {
                return this.nom_r;
            }
            set
            {
                this.nom_r = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public List<Produit> Liste_prod
        {
            get
            {
                return this.liste_prod;
            }
            set
            {
                this.liste_prod = value;
            }
        }

        public string Descriptif
        {
            get
            {
                return this.descriptif;
            }
            set
            {
                this.descriptif = value;
            }
        }

        public int Quantite
        {
            get
            {
                return this.quantite;
            }
            set
            {
                this.quantite = value;
            }
        }

        public float Prix
        {
            get
            {
                return this.prix;
            }
            set
            {
                this.prix = value;
            }
        }

        public float Remuneration
        {
            get
            {
                return this.remuneration;
            }
            set
            {
                this.remuneration = value;
            }
        }

        public int Compteur
        {
            get
            {
                return this.compteur;
            }
            set
            {
                this.compteur = value;
            }
        }

        #endregion

        public void AjouteRecetteSQL()
        {
            string nom_r;
            string type;
            List<Produit> liste_prod;
            string descriptif;
            int quantite;
            float prix;
            float remuneration;
            int compteur;


            Console.WriteLine("Saisir nom recette : ");
            nom_r = Console.ReadLine();

            Console.WriteLine("Saisir type : ");
            type = Console.ReadLine();

            Console.WriteLine("Saisir la liste des produits : ");
            liste_prod = Console.ReadLine();

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
