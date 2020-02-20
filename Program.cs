using System;
using System.Collections.Generic;

namespace JurassicPark
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello! Welcome to Jurassic Park");
      Console.Write("What is your name?");
      var user = Console.ReadLine().ToLower();
      Console.WriteLine($"{user} Welcome! Here at Jurassic Park we have many of Dinosaurs in our inventory.");
      Console.WriteLine("Your options are ");

      bool dinoAnswer = true;
      while (dinoAnswer)
      {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("(VIEW ALL), (ADD), (REMOVE), (TRANSFER), (TOP HEAVY ), (DIET), (QUIT)");
        var input = Console.ReadLine().ToLower();
        if (input == "view all")
        {
          var currentview =
        }
        else if (input == "add")
        {
          Console.WriteLine($"What is the name of dinosaur?");
          var name = Console.ReadLine().ToLower();
          Console.WriteLine("Is your dinosaur a herbivore or carnivore?");
          var diet = Console.ReadLine().ToLower();
          Console.WriteLine("What is the weight of your Dinosour in pounds?");
          var weight = Console.ReadLine().ToLower();


        }
        else if (input == "remove")
        {

        }
        else if (input == "transfer")
        {

        }
        else if (input == "top heavy 3")
        {

        }
        else if (input == "diet")
        {

        }
        else if (input == "quit")

        {
          dinoAnswer = false;
          Console.WriteLine($"Thank you {user} for visiting Jurassic Park!");

        }

      }
    }
  }
}