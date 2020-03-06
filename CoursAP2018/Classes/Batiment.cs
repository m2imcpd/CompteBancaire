using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Batiment
    {
        private string adresse;
        public string Adresse { get => adresse; set => adresse = value; }

        public Batiment()
        {

        }

        public Batiment(string ad)
        {
            Adresse = adresse;
        }

        public override string ToString()
        {
            return $"Adresse : {Adresse}";
        }
    }
}
