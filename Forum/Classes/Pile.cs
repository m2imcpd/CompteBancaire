using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Classes
{
    public class Pile<T>
    {
        private T[] tableau;

        private int compteur = 0;
        public Pile(int taille)
        {
            tableau = new T[taille];
        }

        public void Empiler(T element)
        {
            if(compteur < tableau.Length)
            {
                tableau[compteur] = element;
                compteur++;
            }
        }

        public void Depiler()
        {
            if(compteur > 0)
            {
                tableau[compteur - 1] = default(T);
                compteur--;
            }
        }

        public T GetElement(int index)
        {
            if(index < tableau.Length && index >= 0)
            {
                return tableau[index];
            }
            else
            {
                return default(T);
            }
        }
    }
}
