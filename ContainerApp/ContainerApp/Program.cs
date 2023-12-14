using ContainerApp.Zoo;
using System;

namespace ContainerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var opener = new ZooOpener();
            opener.Open();

            Console.WriteLine("END");
        }
    }
}