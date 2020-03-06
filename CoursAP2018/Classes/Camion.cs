using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Camion : Vehicule
    {
        public override void Accelerer()
        {
            Console.WriteLine("Camion accélère");
        }

        public override void Demarrer()
        {
            Console.WriteLine("Camion démarre");
        }
    }
}
