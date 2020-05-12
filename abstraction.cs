using System;

namespace Abstraction
{
    abstract class SecretMessage
    {
        public void mySecretMessage()
        {
            Console.WriteLine("Painting is the practice of applying paint, pigment, color ");
        }
    }

    class PublicMessage : SecretMessage
    {
        public void myPublicMessage()
        {
            Console.WriteLine("Painting History!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PublicMessage myPubMsg = new PublicMessage();
            myPubMsg.myPublicMessage();
            myPubMsg.mySecretMessage();
        }
    }
}