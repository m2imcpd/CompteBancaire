using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Classes
{
    public class IHMForum
    {

        private Forum forum;

        public IHMForum()
        {
            forum = new Forum();
            Start();
        }

        private void Start()
        {
            Moderateur m = new Moderateur();
            Console.Write("Nom du modérateur : ");
            m.Nom = Console.ReadLine();
            Console.Write("Prénom du modérateur : ");
            m.Prenom = Console.ReadLine();
            Console.Write("Age du modérateur : ");
            m.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email du modérateur : ");
            m.Email = Console.ReadLine();
            forum.Moderateur = m;
            MenuPrincipal();
        }

        public void MenuPrincipal()
        {
            string choix;
            do
            {
                Console.WriteLine("1--Modérateur");
                Console.WriteLine("2--Abonné");
                Console.WriteLine("0--Quitter");
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
                {
                    case "1":
                        ActionModerateur();
                        break;
                    case "2":
                        ActionAbonne();
                        break;
                }
            } while (choix != "0");
        }

        private Abonne AbonneExist()
        {
            Console.Write("Adresse email de l'abonné : ");
            string email = Console.ReadLine();
            Abonne abonne = null;
            foreach(Abonne a in forum.Abonnes)
            {
                if(a.Email == email)
                {
                    abonne = a;
                    break;
                }
            }
            return abonne;
        }

        private bool ModerateurExist()
        {
            Console.Write("Adresse email du modérateur : ");
            string email = Console.ReadLine();
            if(forum.Moderateur.Email == email)
            {
                return true;
            }
            return false;
        }

        private void ActionAbonne()
        {
            Abonne abonne = AbonneExist();
            if (abonne != null)
            {
                string choix;
                do
                {
                    MenuAbonne();
                    choix = Console.ReadLine();
                    Console.Clear();
                    switch (choix)
                    {
                        case "1":
                            ActionAjouterNouvelle(abonne);
                            break;
                        case "2":
                            ActionRepondreNouvelle(abonne);
                            break;
                        case "3":
                            ActionListeNouvelles();
                            break;

                    }
                } while (choix != "0");
            }
            else
            {
                Console.WriteLine("Abonné inconnu");
            }
            
        }


        private void ActionModerateur()
        {
            if(ModerateurExist())
            {
                string choix;
                do
                {
                    MenuModerateur();
                    choix = Console.ReadLine();
                    Console.Clear();
                    switch (choix)
                    {
                        case "1":
                            ActionAjouterNouvelle(forum.Moderateur);
                            break;
                        case "2":
                            ActionRepondreNouvelle(forum.Moderateur);
                            break;
                        case "3":
                            ActionListeNouvelles();
                            break;
                        case "4":
                            ActionListeAbonne();
                            break;
                        case "5":
                            ActionAjouterAbonne();
                            break;
                        case "6":
                            ActionSupprimerAbonne();
                            break;
                        case "7":
                            ActionSupprimerNouvelle();
                            break;
                    }
                } while (choix != "0");
            }
            else
            {
                Console.WriteLine("----Erreur modérateur-----");
            }
        }


        private void MenuAbonne()
        {
            Console.WriteLine("1---Ajouter une nouvelle");
            Console.WriteLine("2---Répondre une nouvelle");
            Console.WriteLine("3---Liste des nouvelles");
        }
        
        private void ActionAjouterNouvelle(Abonne abonne)
        {
            Nouvelle n = new Nouvelle();
            Console.WriteLine("Sujet Nouvelle : ");
            n.Sujet = Console.ReadLine();
            Console.WriteLine("Contenu de la nouvelle : ");
            n.Contenu = Console.ReadLine();
            abonne.AjouterNouvelle(n, forum);
            Console.WriteLine($"----nouvelle ajouté avec l'id : {n.Id}--------");
        }
        private void ActionRepondreNouvelle(Abonne abonne)
        {
            ActionListeNouvelles();
            Console.Write("Id Nouvelle : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Nouvelle nouvelle = null;

            foreach(Nouvelle n in forum.Nouvelles)
            {
                if(n.Id == id)
                {
                    nouvelle = n;
                    break;
                }
            }
            if(nouvelle != null)
            {
                Console.Write("Réponse nouvelle : ");
                string reponse = Console.ReadLine();
                abonne.RepondreNouvelle(nouvelle, forum, reponse);
                Console.WriteLine("--Réponse envoyée-----");
            }
            else
            {
                Console.WriteLine("--aucune nouvelle avec cet id");
            }
        }

        private void ActionListeNouvelles()
        {
            foreach(Nouvelle n in forum.Nouvelles)
            {
                Console.WriteLine(n);
            }
        }

        private void MenuModerateur()
        {
            MenuAbonne();
            Console.WriteLine("4---Liste des abonnes");
            Console.WriteLine("5---Ajouter un abonne");
            Console.WriteLine("6---Supprimer un abonne");
            Console.WriteLine("7---Supprimer une nouvelle");
        }

        private void ActionListeAbonne()
        {
            foreach(Abonne a in forum.Abonnes)
            {
                Console.WriteLine(a);
            }
        }

        private void ActionAjouterAbonne()
        {
            Abonne a = new Abonne();
            Console.Write("Nom Abonné : ");
            a.Nom = Console.ReadLine();
            Console.Write("Prénom Abonné : ");
            a.Prenom = Console.ReadLine();
            Console.Write("Email : ");
            a.Email = Console.ReadLine();
            Console.Write("Age : ");
            a.Age = Convert.ToInt32(Console.ReadLine());
            forum.Moderateur.AjouterAbonne(a, forum);
            Console.WriteLine("---Abonné ajouté-----");
        }

        private void ActionSupprimerNouvelle()
        {
            ActionListeNouvelles();
            Console.Write("Id de la nouvelle : ");
            int id = Convert.ToInt32(Console.ReadLine());
            if(forum.Moderateur.SupprimerNouvelle(id, forum))
            {
                Console.WriteLine("---nouvelle supprimée-----");
            }
            else
            {
                Console.WriteLine("----Nouvelle inconnue-----");
            }
        }

        private void ActionSupprimerAbonne()
        {
            ActionListeAbonne();
            Console.Write("Email de l'abonné : ");
            string email = Console.ReadLine();
            if(forum.Moderateur.SupprimerAbonne(email, forum))
            {
                Console.WriteLine("----Abonné est supprimé-----");
            }
            else
            {
                Console.WriteLine("---Abonné inconn----");
            }
        }
    }
}
