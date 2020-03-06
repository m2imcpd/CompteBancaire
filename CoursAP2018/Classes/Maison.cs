using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Maison : Batiment
    {
        private int nbPieces;

        public int NbPieces { get => nbPieces; set => nbPieces = value; }

        public Maison() : base()
        {

        }

        public Maison(string adresse, int nbP) : base(adresse)
        {
            NbPieces = nbP;
        }

        public override string ToString()
        {
            return $"Adresse Maison {Adresse}, Nombre pièces : {NbPieces}";
        }
    }
}
