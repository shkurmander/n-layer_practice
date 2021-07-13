using n_layer.UserAPI;
using System;

namespace n_layer.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new UIRepo();
            UIRepo.DrawMainMenu();
            Console.ReadKey();
        }
    }
}
