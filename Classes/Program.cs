using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Breed="Chuwawa";
            myDog.Color="Brown";
            Console.WriteLine(myDog.Bark());
            Console.WriteLine(myDog.Walk("Left"));
            Console.WriteLine(myDog.Detail());
        }
    }
}
