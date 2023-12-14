using ContainerApp.Zoo;
using LionPlugin;
using System;

namespace ContainerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opener = new ZooOpener();
            opener.Open();

            var animal1 = new Lion();
            animal1.Add();
            animal1.Sound();

            Console.WriteLine("END");
        }
    }
}