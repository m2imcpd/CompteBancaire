using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Personne
    {
        #region cours
        ////Attributes
        //private string nom;
        //private string prenom;
        //private int age;
        ////Propriétés
        //public string Nom { get { return nom; } set { 
        //        nom = value; 
        //    } 
        //}
        //public string Prenom { get => prenom; set => prenom = value; }
        //public int Age { get => age; set => age = value; }

        ////Méthodes
        ////public string GetNom()
        ////{
        ////    return nom;
        ////}
        ////public void SetNom(string n)
        ////{
        ////    nom = n;
        ////}
        //public void Afficher()
        //{
        //    Console.WriteLine(nom + " " + Prenom + " " + Age);
        //}

        //public virtual void Afficher(string message)
        //{
        //    Afficher();
        //    Console.WriteLine(message + " "+nom + " " + Prenom + " " + Age);
        //}

        ////Constructeur
        //public Personne()
        //{

        //}

        //public Personne(string nom, string prenom) : this()
        //{
        //    Nom = nom;
        //    Prenom = prenom;
        //}

        //public Personne(int age)
        //{
        //    Age = age;
        //}

        //public Personne(string nom, string prenom, int age) : this(nom, prenom)
        //{
        //    //Nom = nom;
        //    //Prenom = prenom;
        //    Age = age;
        //}
        #endregion

        #region exercice
        private string nom;
        private string prenom;
        private DateTime dateNaissance;

        private int age;
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public int Age { get => age; set { 
            if(value < 0 || value > 120)
                {
                    //throw new Exception("Erreur age");
                    throw new AgeException();
                }
            else
                {
                    age = value;
                }
            } 
        }
        public Personne()
        {

        }
        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public virtual void Afficher()
        {
            Console.WriteLine($"Nom : {Nom}, Prénom : {Prenom}, DateNaissance : {DateNaissance}");
        }

        #endregion
    }
}
