using System;
using System.Collections.Generic;
using System.Text;

namespace DM_BDD
{
    class Produit
    {
        public string nom_p;
        public string categorie;
        public float stock_a;
        public float stock_min;
        public float stock_max;
        public string nom_f;
        public int ref_f;
        public int unite;

        public Produit(string Nom_p,string Categorie,float Stock_a,float Stock_min,float Stock_max, string Nom_f,int Ref_f,int Unite)
        {
            this.nom_p = Nom_p;
            this.categorie = Categorie;
            this.stock_a = Stock_a;
            this.stock_min = Stock_min;
            this.stock_max = Stock_max;
            this.nom_f = Nom_f;
            this.ref_f = Ref_f;
            this.unite = Unite;
        }

        #region Constructeur
        public string Nom
        {
            get
            {
                return this.nom_p;
            }
            set
            {
                this.nom_p = value;
            }
        }

        public string Categorie
        {
            get
            {
                return this.categorie;
            }
            set
            {
                this.categorie = value;
            }
        }

        public float Stock_a
        {
            get
            {
                return this.stock_a;
            }
            set
            {
                this.stock_a = value;
            }
        }

        public float Stock_min
        {
            get
            {
                return this.stock_min;
            }
            set
            {
                this.stock_min = value;
            }
        }

        public float Stock_max
        {
            get
            {
                return this.stock_max;
            }
            set
            {
                this.stock_max = value;
            }
        }

        public string Nom_f
        {
            get
            {
                return this.nom_f;
            }
            set
            {
                this.nom_f = value;
            }
        }

        public int Ref_f
        {
            get
            {
                return this.ref_f;
            }
            set
            {
                this.ref_f = value;
            }
        }

        public int Unite        
        {
            get
            {
                return this.unite;
            }
            set
            {
                this.unite = value;
            }
        }

        #endregion



    }
}
