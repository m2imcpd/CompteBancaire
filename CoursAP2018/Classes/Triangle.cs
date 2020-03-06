using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Triangle : Figure
    {
        private int baseTriangle;

        private int hauteur;

        public Triangle(int pX, int pY, int h, int b)
        {
            posX = pX;
            posY = pY;
            hauteur = h;
            baseTriangle = b;
        }
        protected override void Afficher()
        {
            Console.WriteLine($"Triangle, posX : {posX}, posY : {posY}, hauteur : {hauteur}, base : {baseTriangle}");
        }
    }
}
