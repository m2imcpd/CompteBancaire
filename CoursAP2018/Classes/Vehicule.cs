using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public abstract class Vehicule
    {
        private int matricule;
        private int annee;
        private decimal prix;

        private static int compteur = 0;

        public int Matricule { get => matricule; }
        public int Annee { get => annee; set => annee = value; }
        public decimal Prix { get => prix; set => prix = value; }

        public Vehicule()
        {
            compteur++;
            matricule = compteur;
        }

        public abstract void Demarrer();
        public abstract void Accelerer();

        public override string ToString()
        {
            return $"Matricule {Matricule}, année : {Annee}, Prix : {Prix}";
        }

    }
}
