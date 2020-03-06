using CoursAP2018.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Rectangle : Figure, IDeformable
    {
        protected int hauteur;
        protected int largeur;

        public Rectangle(int pX, int pY, int l, int h)
        {
            posX = pX;
            posY = pY;
            hauteur = h;
            largeur = l;
        }

        public Figure Deformation(int coeffH, int coeffV)
        {
            Figure f;
            if(coeffH * largeur != coeffV * hauteur)
            {
                if(coeffH * largeur > coeffV * hauteur)
                {
                    f = new Rectangle(posX, posY, coeffV * hauteur, coeffH * largeur);
                }
                else
                {
                    f = new Rectangle(posX, posY, coeffH * largeur, coeffV * hauteur);
                }
            }
            else
            {
                f = new Carre(posX, posY, coeffH * largeur);
            }
            return f;
        }

        protected override void Afficher()
        {
            Console.WriteLine($"Rectangle, posX : {posX}, posY : {posY}, largeur : {largeur}, Hauteur : {hauteur}");
        }
    }
}
