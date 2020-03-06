using CoursAP2018.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Chien : ICri
    {
        public void Crier()
        {
            Console.WriteLine("Chien qui cri");
        }
    }
}
