using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Classes
{
    public class Nouvelle
    {
        private int id;
        private string sujet;
        private string contenu;
        private static int compteur = 0;

        public string Sujet { get => sujet; set => sujet = value; }
        public string Contenu { get => contenu; set => contenu = value; }
        public int Id { get => id; set => id = value; }

        public Nouvelle()
        {
            compteur++;
            Id = compteur;
        }

        public override string ToString()
        {
            return $"Id : {Id}, Sujet : {Sujet}, Contenu : {Contenu}";
        }
    }
}
