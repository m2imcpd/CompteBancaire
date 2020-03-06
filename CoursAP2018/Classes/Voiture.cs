using CoursAP2018.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoursAP2018.Classes
{
    public class Voiture : Vehicule, IRoule
    {
        public event Action<decimal> Promotion;
        public override void Accelerer()
        {
            Console.WriteLine("Voiture accélère");
        }

        public override void Demarrer()
        {
            Console.WriteLine("Voiture démarre");
        }

        public void Rouler()
        {
            Console.WriteLine("Voiture qui roule");
        }

        public void Reduction(decimal reduction)
        {
            Prix -= reduction;
            //if(Promotion != null)
            //{
            //    Promotion(Prix);
            //}

            Promotion?.Invoke(Prix);

        }
    }
}
