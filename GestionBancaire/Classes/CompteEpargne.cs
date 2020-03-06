using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBancaire.Classes
{
    public class CompteEpargne : Compte
    {
        private double taux;

        public double Taux { get => taux; set => taux = value; }
    }
}
