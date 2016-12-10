using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP2
{
    public class Conversion
    {
        private String nomMonnaie;
        private float tauxMonnaie;

        public Conversion()
        {
        }
        public Conversion(float taux)
        {
            this.tauxMonnaie = taux;
        }
        public Conversion(String nom ,float taux) 
        {
            this.nomMonnaie = nom;
            this.tauxMonnaie = taux;
        }
        public float valeur
        {
            get { return tauxMonnaie; }
            set { tauxMonnaie = value; }
        }
        public String nom
        {
            get { return nomMonnaie; }
            set { nomMonnaie = value; }
        }
        public override String ToString()
        {
            return "(" + nomMonnaie + " vaut " + nomMonnaie + "$ )";
        }
        public float converter (float monnaie){
            float montant = monnaie * this.valeur;
            return montant;
        }
     
    }
}