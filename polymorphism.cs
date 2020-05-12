using System;

namespace Polymorphism
{
    class Painting
    {
        public virtual void paint()
        {
            Console.WriteLine("Painting Type");
        }
    }

    class OilPainting : Painting
    {
        public override void paint()
        {
            Console.WriteLine("Oil painting.");
        }
    }

    class DigitalPainting : Painting
    {
        public override void paint()
        {
            Console.WriteLine("Digital Painting");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Painting myPainting = new Painting();
            Painting myOilPainting = new OilPainting();
            Painting myDigitalPainting = new DigitalPainting();
            myPainting.paint();
            myOilPainting.paint();
            myDigitalPainting.paint();
        }
    }
}