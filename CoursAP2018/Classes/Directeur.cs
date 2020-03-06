using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Directeur : Chef
    {
        private string societe;

        public string Societe { get => societe; set => societe = value; }

        public Directeur(string nom, string prenom, DateTime dateNaissance, decimal salaire, string service, string societe) : base(nom, prenom, dateNaissance, salaire, service)
        {

            Societe = societe;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Societé : {Societe}");
        }
    }
}
