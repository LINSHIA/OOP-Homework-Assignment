using System;

namespace Encapsulation
{
    class Painting
    {
        private string name;
        private string artist;
        private string medium;
        private int year;

        public string PaintingName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string PaintingArtist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }

        public string PaintingMedium
        {
            get
            {
                return medium;
            }
            set
            {
                medium = value;
            }
        }

        public int PaintingYear
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public virtual void style()
        {
            Console.WriteLine("Painting Styles");
        }
    }
    class Classic : Painting
    {
        public override void style()
        {
            Console.WriteLine("Ink wash Painting");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Painting InkwashPainting = new Painting();

            InkwashPainting.PaintingName = "Pine Trees screen";
            InkwashPainting.PaintingArtist = "Lin Jim";
            InkwashPainting.PaintingMedium = "Ink wash Painting";
            InkwashPainting.PaintingYear = 2020;

            Console.WriteLine("Name: " + InkwashPainting.PaintingName);
            Console.WriteLine("Artist: " + InkwashPainting.PaintingArtist);
            Console.WriteLine("Medium: " + InkwashPainting.PaintingMedium);
            Console.WriteLine("Year: " + InkwashPainting.PaintingYear);
        }
    }
}