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
                        ActionEffectuerDepot();
                        break;
                    case "3":
                        ActionEffectuerRetrait();
                        break;
                    case "4":
                        ActionAfficherOperations();
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
                        ActionCreationCompteEpargne();
                        break;
                    case "3":
                        ActionCreationComptePayant();
                        break;
                }
            } while (choix != "0");
        }

        private void ActionEffectuerDepot()
        {
            Console.Write("Saisir le numéro de compte : ");
            string numero = Console.ReadLine();
            Compte compte = null;
            compte = Compte.GetCompteByNumero(numero);

            if (compte == null)
            {
                Console.WriteLine("Aucun compte avec ce numéro : ");
            }
            else
            {
                Console.Write("Montant du dépot : ");
                decimal depot = Convert.ToDecimal(Console.ReadLine());
                Operation operation = new Operation
                {
                    CompteId = compte.Id,
                    Montant = depot,
                    DateOperation = DateTime.Now
                };
                operation.Save();
                compte.AjouterOperation(operation);
                Console.WriteLine("Opération éfféctuée : ");
                Console.WriteLine(compte);
            }
        }

        private void ActionEffectuerRetrait()
        {
            Console.Write("Saisir le numéro de compte : ");
            string numero = Console.ReadLine();
            Compte compte = Compte.GetCompteByNumero(numero);
            if (compte == null)
            {
                Console.WriteLine("Aucun compte avec ce numéro : ");
            }
            else
            {
                Console.Write("Montant du retrait : ");
                decimal retrait = Convert.ToDecimal(Console.ReadLine());
                if(retrait <= compte.Solde)
                {
                    Operation operation = new Operation
                    {
                        CompteId = compte.Id,
                        Montant = retrait * -1,
                        DateOperation = DateTime.Now
                    };
                    operation.Save();
                    compte.AjouterOperation(operation);
                    Console.WriteLine("Opération éfféctuée : ");
                    Console.WriteLine(compte);
                }
                else
                {
                    Console.WriteLine("Opération impossible");
                }
                
            }
        }

        private void ActionAfficherOperations()
        {
            Console.Write("Saisir le numéro de compte : ");
            string numero = Console.ReadLine();
            Compte compte = Compte.GetCompteByNumero(numero);
            if (compte == null)
            {
                Console.WriteLine("Aucun compte avec ce numéro : ");
            }
            else
            {
                Console.WriteLine(compte);
                foreach(Operation o in compte.Operations)
                {
                    Console.WriteLine(o);
                }
            }
        }

        private void ActionCreationCompteCourant()
        {
            Client client = CreationClient();

            Compte compte = new Compte()
            {
                ClientId = client.Id
            };
            if(compte.Save())
            {
                Console.WriteLine("Compte crée avec le numéro de compte " + compte.Numero);
            }
        }

        private void ActionCreationComptePayant()
        {
            Client client = CreationClient();
            Console.Write("Cout operation : ");
            decimal cOperation = Convert.ToDecimal(Console.ReadLine());
            ComptePayant compte = new ComptePayant()
            {
                ClientId = client.Id,
                CoutOperation = cOperation
            };
            if (compte.Save())
            {
                Console.WriteLine("Compte crée avec le numéro de compte " + compte.Numero);
            }
        }

        private void ActionCreationCompteEpargne()
        {
            Client client = CreationClient();
            Console.Write("Taux : ");
            double taux = Convert.ToDouble(Console.ReadLine());
            CompteEpargne compte = new CompteEpargne()
            {
                ClientId = client.Id,
                Taux = taux
            };
            if (compte.Save())
            {
                Console.WriteLine("Compte crée avec le numéro de compte " + compte.Numero);
            }
        }

        private Client CreationClient()
        {
            Console.Write("Téléphone du client : ");
            string telephone = Console.ReadLine();
            Client client = Client.GetClientByTelephone(telephone);
            if (client != null)
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
            return client;
        }
    }

}
