using Forum.Classes;
using System;

namespace Forum
{
    class Program
    {
        static void Main(string[] args)
        {
            //IHMForum ihm = new IHMForum();
            Pile<string> pileString = new Pile<string>(10);
            pileString.Empiler("test");
            pileString.Empiler("coucou");
            pileString.Depiler();
            string element = pileString.GetElement(0);
        }
    }
}
