using System;

namespace Inheritance
{
    class Group
    {
        public string groupName = "World Painting Association";

    }

    class Artist : Group
    {
        public string ArtistName = "Lin Jim";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Artist newArtist = new Artist();

            Console.WriteLine(newArtist.ArtistName + " is a member of: " + newArtist.groupName);
        }
    }
}