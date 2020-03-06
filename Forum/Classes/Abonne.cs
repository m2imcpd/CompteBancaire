using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Classes
{
    public class Abonne
    {
        private string nom;
        private string prenom;
        private int age;
        private string email;
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }

        //private Forum forum;

        public bool AjouterNouvelle(Nouvelle nouvelle, Forum forum)
        {
            forum.Nouvelles.Add(nouvelle);
            return true;
        }

        public bool RepondreNouvelle(Nouvelle nouvelle, Forum forum, string contenu)
        {
            Nouvelle reponse = new Nouvelle() { Contenu = contenu, Sujet = nouvelle.Sujet };
            forum.Nouvelles.Add(reponse);
            return true;
        }

        public override string ToString()
        {
            return $"Nom : {Nom}, Prénom : {Prenom}, Email : {Email}, Age : {Age}";
        }
    }
}
