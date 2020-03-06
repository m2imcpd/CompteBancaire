using CoursAP2018.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Avion : IRoule
    {
        public void Rouler()
        {
            Console.WriteLine("Avion qui Roule");
        }

        public void Voler()
        {
            Console.WriteLine("Avion qui vole");
        }
    }
}
