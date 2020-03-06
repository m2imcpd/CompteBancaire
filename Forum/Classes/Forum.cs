using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Classes
{
    public class Forum
    {
        private List<Nouvelle> nouvelles;
        private List<Abonne> abonnes;
        private Moderateur moderateur;

        public List<Nouvelle> Nouvelles { get => nouvelles; set => nouvelles = value; }
        public List<Abonne> Abonnes { get => abonnes; set => abonnes = value; }
        public Moderateur Moderateur { get => moderateur; set => moderateur = value; }

        public Forum()
        {
            Nouvelles = new List<Nouvelle>();
            Abonnes = new List<Abonne>();
            Moderateur = new Moderateur();
        }


    }
}
