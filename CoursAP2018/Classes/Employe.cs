using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Employe : Personne
    {
        private decimal salaire;

        public decimal Salaire { get => salaire; set => salaire = value; }

        public Employe(string nom, string prenom, DateTime dateNaissance,decimal salaire) : base(nom, prenom, dateNaissance)
        {
            Salaire = salaire;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Salaire : {Salaire} €");
        }


    }
}
