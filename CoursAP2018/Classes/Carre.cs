using CoursAP2018.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Carre : Figure, IDeformable
    {
        private int longueur;

        public Carre(int pX, int pY, int l)
        {
            posX = pX;
            posY = pY;
            longueur = l;
            
        }

        public Figure Deformation(int coeffH, int coeffV)
        {
            Figure f;
            if(coeffH == coeffV)
            {
                f = new Carre(posX, posY, longueur * coeffH);
            }
            else
            {
                if(coeffV > coeffH)
                {
                    f = new Rectangle(posX, posY, coeffH * longueur, coeffV * longueur);
                }
                else
                {
                    f = new Rectangle(posX, posY, coeffV * longueur, coeffH * longueur);
                }
            }
            return f;
        }

        protected override void Afficher()
        {
            Console.WriteLine($"Carré posX : {posX}, posY : {posY}, longueur : {longueur}");
        }
    }
}
