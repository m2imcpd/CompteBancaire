using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.Classes
{
    public class Moderateur : Abonne
    {

        public bool SupprimerNouvelle(int nouvelleId, Forum forum)
        {
            //Nouvelle nouvelleFound = null;
            //foreach(Nouvelle n in forum.Nouvelles)
            //{
            //    if(n.Id == nouvelleId)
            //    {
            //        nouvelleFound = n;
            //        break;
            //    }
            //}

            Nouvelle nouvelleFound = forum.Nouvelles.FirstOrDefault(n => n.Id == nouvelleId);
            if(nouvelleFound != null)
            {
                forum.Nouvelles.Remove(nouvelleFound);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AjouterAbonne(Abonne abonne, Forum forum)
        {
            forum.Abonnes.Add(abonne);
            return true;
        }

        public bool SupprimerAbonne(string emailAbonne, Forum forum)
        {
            Abonne abonneFound = null;
            foreach(Abonne a in forum.Abonnes)
            {
                if(a.Email == emailAbonne)
                {
                    abonneFound = a;
                    break;
                }
            }
            if(abonneFound != null)
            {
                forum.Abonnes.Remove(abonneFound);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
