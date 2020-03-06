using CoursAP2018.Classes;
using CoursAP2018.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CoursAP2018
{
    class Program
    {
        static void Main(string[] args)
        {
            #region cours c# base
            //Console.WriteLine("Hello World!");
            ////Déclaration de variable
            ////type et le nom de la variable
            //int a = 10;
            //a = 20;
            ////Variable short, int , long, float, double, decimal, bool, char, strings 
            ////structure conditionnelle
            ////if else
            //bool majeur;
            //if(a >= 18)
            //{
            //    majeur = true;
            //}
            //else
            //{
            //    majeur = false;
            //}
            ////switch
            //int numeroMois = 1;
            //string mois;

            //switch(numeroMois)
            //{
            //    case 1:
            //        mois = "Janvier";
            //        break;
            //    case 2:
            //        mois = "Février";
            //        break;
            //    default:
            //        mois = "Erreur";
            //        break;
            //}
            ////ternaire
            ////majeur = (a >= 18) ? true : false;
            //majeur = (a >= 18);
            ////boucle
            ////for
            //for(int i=0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            ////while
            //int j = 100;
            //while(j >  0)
            //{
            //    Console.WriteLine(j);
            //    j--;
            //}

            ////do while
            //int k = 0;
            //do
            //{
            //    Console.WriteLine(k);
            //    k--;
            //} while (k > 0);
            ////Insctruction d'ecriture
            ////Ecrire un  element
            //Console.Write("Element sans retour à la ligne");
            ////Ecrire avec retour à la ligne
            //Console.WriteLine("Element avec retour à la ligne");
            //Insctruction de l'ecture
            //Console.Write("Merci de saisir votre nom : ");
            //string nom = Console.ReadLine();
            //Console.WriteLine(nom);
            //Console.Write("Votre âge : ");
            ////Méthode de convertion de la classe Convert
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);
            //Correction exercice 1
            //Console.Write("Merci de saisir un nombre : ");
            //int nombre = Convert.ToInt32(Console.ReadLine());
            //int total;
            //string chaine = "";
            //for(int i= 1; i < nombre/2 + 1; i++)
            //{
            //    total = i;
            //    chaine = nombre + " = "+i;
            //    for(int j = i+1; j <= nombre/2 + 1; j++)
            //    {
            //        total += j;
            //        chaine += " +" + j;
            //        if(total == nombre)
            //        {
            //            Console.WriteLine(chaine);
            //            break;
            //        }
            //    }
            //}
            //Correction exercice 2
            //Console.Write("Ancienneté : ");
            //int anciennete = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Age : ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Salaire : ");
            //decimal salaire = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Cadre (O/N) : ");
            //bool cadre = Console.ReadLine() == "O";
            //decimal indemnite = 0;
            //if(anciennete < 10)
            //{
            //    indemnite += anciennete * salaire / 2;
            //}
            //else
            //{
            //    indemnite += (10 * salaire / 2) + ((anciennete - 10) * salaire);
            //}
            //if(cadre)
            //{
            //    if(age >= 46 && age <= 49)
            //    {
            //        indemnite += 2 * salaire;
            //    }
            //    else if(age >= 50)
            //    {
            //        indemnite += 5 * salaire;
            //    }
            //}

            //Console.WriteLine("Votre indemnité est de  : " + indemnite);

            //Correction exercice 3

            //Console.Write("Le nombre d'enfant : ");
            //decimal nbEnfant = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Marié O/N : ");
            //bool marie = Console.ReadLine() == "O";
            //Console.WriteLine("Votre salaire : ");
            //decimal salaire = Convert.ToDecimal(Console.ReadLine());
            //decimal impot = 0;
            //decimal nbPart = 1;
            //if(marie)
            //{
            //    nbPart += 1;
            //}
            //if(nbEnfant <= 2)
            //{
            //    nbPart += nbEnfant / 2;
            //}
            //else
            //{
            //    nbPart += nbEnfant - 1;
            //}
            //decimal salaireImposable = salaire * 0.9M;
            //if(salaireImposable <= 9964)
            //{
            //    impot = 0;
            //}
            //else if(salaireImposable > 9964 && salaireImposable <= 25405)
            //{
            //    impot = (salaireImposable * 0.11M) - (1096.4M * nbPart);
            //}
            //else if (salaireImposable > 25405 && salaireImposable <= 72643)
            //{
            //    impot = (salaireImposable * 0.30M) - (5922.99M * nbPart);
            //}
            //else if (salaireImposable > 72643 && salaireImposable <= 156244)
            //{
            //    impot = (salaireImposable * 0.41M) - (13913.72M * nbPart);
            //}
            //else if (salaireImposable > 1562444 )
            //{
            //    impot = (salaireImposable * 0.45M) - (20163.48M * nbPart);
            //}
            //impot = (impot < 0) ? 0 : impot;
            //Console.WriteLine("Votre impot est de : " + impot);

            //Tableau
            //int[] tab = new int[10];
            //for(int i=0; i < tab.Length; i++)
            //{
            //    Console.Write("Merci de saisir la valeur N° " + (i + 1) +" : ");
            //    tab[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0; i < tab.Length; i++)
            //{
            //    Console.WriteLine(tab[i]);
            //}

            //int[] tab2 = new int[] { 10, 3, 5 };

            //Correction ex4
            //Console.Write("Merci de saisir une date sous forme numerojour/date/mois : ");
            //string chaine = Console.ReadLine();
            //string[] tab = chaine.Split('/');
            //string result = "";
            //switch (tab[0])
            //{
            //    case "1":
            //        result += "Lundi ";
            //        break;
            //    case "2":
            //        result += "Mardi ";
            //        break;
            //    case "3":
            //        result += "Mercredi ";
            //        break;
            //    case "4":
            //        result += "Jeudi ";
            //        break;
            //    case "5":
            //        result += "Vendredi ";
            //        break;
            //    case "6":
            //        result += "Samedi ";
            //        break;
            //    case "7":
            //        result += "Dimanche ";
            //        break;
            //}
            //result += tab[1] + " ";
            //switch (tab[2])
            //{
            //    case "1":
            //        result += "Janvier";
            //        break;
            //    case "2":
            //        result += "Février";
            //        break;
            //    case "3":
            //        result += "Mars";
            //        break;
            //    case "4":
            //        result += "Avril";
            //        break;
            //}

            //Console.WriteLine(result);

            //Correction exercice 5
            //Partie 1
            //Console.Write("Merci de saisir un nombre : ");
            //int nombre = Convert.ToInt32(Console.ReadLine());
            //int mill = nombre / 1000;
            //int cent = (nombre % 1000) / 100;
            //int dix = (nombre % 100) / 10;
            //int unit = nombre % 10;
            //string chaine = "";
            //for(int i=1; i <= mill; i++)
            //{
            //    chaine += "M";
            //}
            //if(cent >= 5)
            //{
            //    chaine += "D";
            //    cent -= 5; 
            //}
            //if(cent >= 4)
            //{
            //    chaine += "ID";
            //}
            //else
            //{
            //    for (int i = 1; i <= cent; i++)
            //    {
            //        chaine += "C";
            //    }
            //}

            //if(dix >= 5)
            //{
            //    chaine += "L";
            //    dix -= 5;
            //}
            //if(dix >= 4)
            //{
            //    chaine += "IL";
            //}
            //else
            //{
            //    for (int i = 1; i <= dix; i++)
            //    {
            //        chaine += "X";
            //    }
            //}

            //if(unit >= 5)
            //{
            //    chaine += "V";
            //    unit -= 5;
            //}
            //if(unit >= 4)
            //{
            //    chaine += "IV";
            //}
            //else
            //{
            //    for (int i = 1; i <= unit; i++)
            //    {
            //        chaine += "I";
            //    }
            //}

            //Console.WriteLine(chaine);

            //Console.WriteLine("Merci de saisir un nombre romain : ");
            //string nombreR = Console.ReadLine();
            //int nombre = 0;
            //for(int i=0; i < nombreR.Length; i++)
            //{
            //    switch(nombreR[i])
            //    {
            //        case 'M':
            //            nombre += 1000;
            //            break;
            //        case 'D':
            //            nombre += 500;
            //            break;
            //        case 'C':
            //            if(nombreR[i+1] == 'D')
            //            {
            //                nombre += 400;
            //                i++;
            //            }
            //            else
            //            {
            //                nombre += 100;
            //            }

            //            break;
            //        case 'L':
            //            nombre += 50;
            //            break;
            //        case 'X':
            //            if(nombreR[i+1] == 'L')
            //            {
            //                nombre += 40;
            //                i++;
            //            }
            //            else
            //            {
            //                nombre += 10;
            //            }
            //            break;
            //        case 'V':
            //            nombre += 5;
            //            break;
            //        case 'I':
            //            if(nombreR[i+1] == 'V')
            //            {
            //                nombre += 4;
            //                i++;
            //            }
            //            else
            //            {
            //                nombre += 1;
            //            }
            //            break;
            //    }
            //}
            //Console.WriteLine(nombre);
            #endregion
            #region cous POO
            //Personne p1 = new Personne("abadi", "ihab", 32);
            //p1.nom = "abadi";
            //p1.prenom = "ihab";
            //p1.age = 32;
            //p1.SetNom("abadi");
            //p1.Nom = "abadi";
            //p1.Prenom = "ihab";
            //Console.WriteLine(p1.Prenom);
            //p1.Afficher("Bonjour");

            //Salarie s = new Salarie("toto", "tata", 30, 2000);
            //s.Afficher("bonjour ");

            //Correction ex1 serie 2

            //Camion c = new Camion();
            //c.Annee = 2010;
            //c.Prix = 10000M;
            //c.Demarrer();
            //c.Accelerer();
            //Console.WriteLine(c);

            //Voiture v = new Voiture() { Annee = 2012, Prix= 20000M };
            //v.Demarrer();
            //c.Accelerer();
            //Console.WriteLine(v);

            //Correction ex3 serie2

            //Personne[] emp = new Personne[8];

            //Employe e = new Employe("nom e1", "prenom e1", DateTime.Now, 2000);
            //emp[0] = e;
            //emp[1] = new Employe("nom e2", "prenom e2", DateTime.Now, 2500);
            //emp[2] = new Employe("nom e3", "prenom e3", DateTime.Now, 2501);
            //emp[3] = new Employe("nom e4", "prenom e4", DateTime.Now, 2503);
            //emp[4] = new Employe("nom e5", "prenom e5", DateTime.Now, 2504);
            //emp[5] = new Chef("nom c1", "prenom c1", DateTime.Now, 3504, "service 1");
            //emp[6] = new Chef("nom c2", "prenom c2", DateTime.Now, 3500, "service 2");
            //emp[7] = new Directeur("nom d1", "prenom d1", DateTime.Now, 4500, "service 2", "societe 1");

            //foreach(Personne p in emp)
            //{
            //    p.Afficher();
            //}

            //List<Employe> liste = new List<Employe>();
            ////Pour ajouter un element dans une liste
            ////on utilise la méthode  Add
            //liste.Add(new Employe("nom e2", "prenom e2", DateTime.Now, 2500));
            ////Pour supprimer un element dans une liste, Remove, RemoveAt, RemoveAll
            //liste.RemoveAt(0);
            ////la taille de la liste
            //Console.WriteLine(liste.Count);

            #endregion
            #region cours interface
            //Voiture v = new Voiture();
            //Avion a = new Avion();
            //List<IRoule> ListeIRoule = new List<IRoule>();
            //ListeIRoule.Add(v);
            //ListeIRoule.Add(a);
            //foreach(IRoule element in ListeIRoule)
            //{
            //    Console.WriteLine(element.GetType());
            //    element.Rouler();
            //    if(element.GetType() == typeof(Voiture))
            //    {
            //        (element as Voiture).Demarrer();
            //        (element as Voiture).Accelerer();
            //    }
            //    else if(element.GetType() == typeof(Avion))
            //    {
            //        (element as Avion).Voler();
            //    }
            //}
            #endregion

            #region exercice interface
            ////Correction exercice 1
            //Chat c = new Chat();
            //Chien ch = new Chien();
            //List<ICri> ListeICri = new List<ICri>();
            //ListeICri.Add(c);
            //ListeICri.Add(ch);
            //foreach(ICri ic in ListeICri)
            //{
            //    ic.Crier();
            //}
            #endregion

            #region passage des paramètres
            //double res = Addition(1, 2, 3, 4);
            //int a;
            //Modification(out a);
            //Console.WriteLine(a);

            //Calculatrice.Calcule(10, 30, Calculatrice.Addition);
            //Calculatrice.Calcule(10, 30, Calculatrice.Soustraction);
            //Calculatrice.Calcule(10, 30, Multiplication);
            ////Calculatrice.Calcule(30, 10, delegate (double a, double b)
            //// {
            ////     return a / b;
            //// });

            //Calculatrice.Calcule(30, 10, (a, b) => a / b);

            //Calculatrice c = new Calculatrice();
            //c.methodeCalcule = Calculatrice.Addition;
            //c.methodeCalcule += Calculatrice.Soustraction;
            //c.methodeCalcule += Multiplication;
            //c.Calcule(10, 30);
            #endregion

            #region event
            //Voiture v = new Voiture { Prix = 3000 };
            //v.Promotion += EnvoieEmail;
            //v.Promotion += (p) =>
            //{
            //    Console.WriteLine($"Notification envoyée avec prix : {p}");
            //};
            //string choix;
            //int compteur = 0;
            //do
            //{
            //    Console.Write("Une reduction ? ");
            //    choix = Console.ReadLine();
            //    if (choix == "O")
            //    {
            //        Console.Write("Reduction : ");
            //        decimal r = Convert.ToDecimal(Console.ReadLine());
            //        v.Reduction(r);
            //        compteur++;
            //    }
            //    if(compteur >= 2)
            //    {
            //        v.Promotion -= EnvoieEmail;
            //    }
            //} while (choix != "0");
            #endregion

            #region cours gestion exception
            //Console.Write("Merci de saisir l'age : ");
            //int age;
            //try
            //{
            //    age = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Votre age est de {age}");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Fin de programme");
            //}
            //bool saisiAgeCorrect = false;
            //Console.Write("Merci de saisir l'age : ");
            //int age;
            //while (!saisiAgeCorrect)
            //{
            //    try
            //    {
            //        age = Convert.ToInt32(Console.ReadLine());
            //        saisiAgeCorrect = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.Write("Merci de saisir un chiffre : ");
            //    }
            //}
            //int age;
            //bool saisiAgeCorrect = false;
            //do
            //{
            //    Console.Write("Merci de saisir votre âge : ");
            //    saisiAgeCorrect = Int32.TryParse(Console.ReadLine(), out age);
            //} while (!saisiAgeCorrect);

            //Personne p = new Personne();
            //try
            //{
            //    p.Age = 140;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region cours Ado.net
            //Etablir une connexion à notre base de donnée
            //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\ap2018;Integrated Security=True");
            //string request = "CREATE TABLE contact (" +
            //    "id int not null primary key IDENTITY(1,1)," +
            //    "nom nvarchar(100) not null," +
            //    "prenom nvarchar(100) not null," +
            //    "email varchar(100) not null" +
            //    ")";
            ////Execution d'une request
            //SqlCommand command = new SqlCommand(request, connection);
            //connection.Open();
            //command.ExecuteNonQuery();
            //command.Dispose();
            //connection.Close();
            //Console.Write("Sasir l'id : ");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Saisir le nom : ");
            //string nom = Console.ReadLine();
            //Console.Write("Saisir le prénom : ");
            //string prenom = Console.ReadLine();
            //Console.Write("Saisir l'email : ");
            //string email = Console.ReadLine();
            //string request = "INSERT INTO contact(nom, prenom, email) OUTPUT INSERTED.ID values(@nom,@prenom,@email)";
            //SqlCommand command = new SqlCommand(request, connection);
            //command.Parameters.Add(new SqlParameter("@nom", nom));
            //command.Parameters.Add(new SqlParameter("@prenom", prenom));
            //command.Parameters.Add(new SqlParameter("@email", email));
            //connection.Open();
            //int lastId = (int)command.ExecuteScalar();
            //connection.Close();
            //Console.WriteLine($"Contact ajouté avec id {lastId}");

            //string request = "UPDATE contact set nom = @nom, prenom = @prenom , email = @email WHERE id=@id";
            //SqlCommand command = new SqlCommand(request, connection);
            //command.Parameters.Add(new SqlParameter("@nom", nom));
            //command.Parameters.Add(new SqlParameter("@prenom", prenom));
            //command.Parameters.Add(new SqlParameter("@email", email));
            //command.Parameters.Add(new SqlParameter("@id", id));

            //connection.Open();
            //if(command.ExecuteNonQuery() > 0 )
            //{
            //    Console.WriteLine("Modifcation effectuée");
            //}else
            //{
            //    Console.WriteLine($"Aucun contact avec l'id {id}");
            //}
            //connection.Close();

            //Lecture des données
            //string request = "SELECT * FROM contact";
            //SqlCommand command = new SqlCommand(request, connection);
            //connection.Open();
            //SqlDataReader reader = command.ExecuteReader();
            //while(reader.Read())
            //{
            //    Console.WriteLine($"Id : {reader.GetInt32(0)} Nom : {reader.GetString(1)}, Prénom : {reader.GetString(2)}, email : {reader.GetString(3)}");
            //}
            //reader.Close();
            //connection.Close();

            string choix;
            do
            {
                Console.WriteLine("1- Créer un contact");
                Console.WriteLine("2- Modifier un contact");
                Console.WriteLine("3- Supprimer un contact");
                Console.WriteLine("4- Liste des contacts");
                choix = Console.ReadLine();
                Contact contact;
                int searchContactId;
                switch (choix)
                {
                    case "1":
                        contact = new Contact();
                        Console.Write("Nom : ");
                        contact.Nom = Console.ReadLine();
                        Console.Write("Prénom : ");
                        contact.Prenom = Console.ReadLine();
                        if(contact.Save())
                        {
                            string email;
                            do
                            {
                                Console.Write("Email : ");
                                email = Console.ReadLine();
                                if(email != "0")
                                {
                                    Email e = new Email
                                    {
                                        Mail = email,
                                        ContactId = contact.Id
                                    };
                                    e.Save();
                                }
                            } while (email != "0");

                            Console.WriteLine($"Contact ajouté avec id : {contact.Id}");

                        }
                        else
                        {
                            Console.WriteLine("Erreur serveur");
                        }
                        break;
                    case "2":
                        Console.Write("L'id du contact à modifier : ");
                        searchContactId = Convert.ToInt32(Console.ReadLine());
                        contact = Contact.GetContactById(searchContactId);
                        if(contact == null)
                        {
                            Console.WriteLine("Aucun contact avec cet id");
                        }
                        else
                        {
                            Console.Write("Nom : ");
                            contact.Nom = Console.ReadLine();
                            Console.Write("Prénom : ");
                            contact.Prenom = Console.ReadLine();
                            if(contact.Update())
                            {
                                Console.WriteLine("Contact mis à jour");
                            }
                            else
                            {
                                Console.WriteLine("Erreur serveur");
                            }
                        }
                        break;
                    case "3":
                        Console.Write("L'id du contact à supprimer : ");
                        searchContactId = Convert.ToInt32(Console.ReadLine());
                        contact = Contact.GetContactById(searchContactId);
                        if (contact == null)
                        {
                            Console.WriteLine("Aucun contact avec cet id");
                        }
                        else
                        {   
                            if (contact.Delete())
                            {
                                Console.WriteLine("Contact supprimé");
                            }
                            else
                            {
                                Console.WriteLine("Erreur serveur");
                            }
                        }
                        break;
                    case "4":
                        foreach(Contact c in Contact.GetContacts())
                        {
                            Console.WriteLine(c);
                            Console.WriteLine("Emails : ");
                            foreach(Email e in c.Emails)
                            {
                                Console.WriteLine(e);
                            }
                            Console.WriteLine("------------");
                        }
                        break;
                }
            } while (choix != "0");
            #endregion
        }

        static void EnvoieEmail(decimal prix)
        {
            Console.WriteLine($"Email envoyé avec nouveau prix :  {prix}");
        }
        static double Multiplication(double a, double b)
        {
            return a * b;
        }
        static double Addition(params double[] tab)
        {
            double total = 0;
            foreach(double a in tab)
            {
                total += a;
            }
            return total;
        }

        static void Modification(out int a)
        {
            a = 10;
            a *= 2;
        }
    }
}
