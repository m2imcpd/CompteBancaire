using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Chef : Employe
    {
        private string service;

        public string Service { get => service; set => service = value; }

        public Chef(string nom, string prenom, DateTime dateNaissance, decimal salaire, string service) : base(nom, prenom, dateNaissance, salaire)
        {
            Service = service;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Service : {Service}");
        }
    }
}
