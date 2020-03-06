using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBancaire.Classes
{
    public class IHM
    {

        public IHM()
        {
            Start();
        }

        private void MenuPrincipal()
        {
            Console.WriteLine("1--Création de compte");
            Console.WriteLine("2--Effectuer un dépot");
            Console.WriteLine("3--Effectuer un retrait");
            Console.WriteLine("4--Afficher opérations et solde : ");
        }

        private void MenuCreationCompte()
        {
            Console.WriteLine("1--Création de compte courant");
            Console.WriteLine("2--Création de compte épargne");
            Console.WriteLine("3--Création de compte payant");
        }

        private void Start()
        {
            string choix;
            do
            {
                MenuPrincipal();
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
                {
                    case "1":
                        ActionCreationCompte();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }
            } while (choix != "0");
        }

        private void ActionCreationCompte()
        {
            string choix;
            do
            {
                MenuCreationCompte();
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
                {
                    case "1":
                        ActionCreationCompteCourant();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }
            } while (choix != "0");
        }

        private void ActionCreationCompteCourant()
        {
            Console.Write("Téléphone du client : ");
            string telephone = Console.ReadLine();
            Client client = Client.GetClientByTelephone(telephone);
            if(client != null)
            {
                Console.WriteLine(client);
            }
            else
            {
                Console.Write("Nom du client : ");
                string nom = Console.ReadLine();
                Console.Write("Prénom du client : ");
                string prenom = Console.ReadLine();
                client = new Client
                {
                    Nom = nom,
                    Prenom = prenom,
                    Telephone = telephone
                };
                if (client.Save())
                {
                    Console.WriteLine("Client enregistré : ");
                    Console.WriteLine(client);
                }
            }

            Compte compte = new Compte()
            {
                ClientId = client.Id
            };
            if(compte.Save())
            {
                Console.WriteLine("Compte crée avec le numéro de compte " + compte.Numero);
            }
        }
    }

}
