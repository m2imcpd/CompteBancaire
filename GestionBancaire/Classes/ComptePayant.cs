using System;
using System.Collections.Generic;
using System.Text;

namespace GestionBancaire.Classes
{
    public class ComptePayant : Compte
    {
        private decimal coutOperation;

        public decimal CoutOperation { get => coutOperation; set => coutOperation = value; }
    }
}
