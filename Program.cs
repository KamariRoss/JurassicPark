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

      var zoo = new DinoString();
      zoo.Dinosaurs.Add(new DinoClass { Name = "Trex", Weight = 600, EnclosureNumber = 3, DietType = "Carnivore" });
      zoo.Dinosaurs.Add(new DinoClass { Name = "Saber Tooth", Weight = 200, EnclosureNumber = 3, DietType = "Carnivore" });
      zoo.Dinosaurs.Add(new DinoClass { Name = "Plesiosaurus", Weight = 800, EnclosureNumber = 4, DietType = "Herbivore" });
      zoo.Dinosaurs.Add(new DinoClass { Name = "Stegosauruses", Weight = 500, EnclosureNumber = 5, DietType = "Herbivore" });
      zoo.Dinosaurs.Add(new DinoClass { Name = "Dire Wolf", Weight = 200, EnclosureNumber = 7, DietType = "Carnivore" });
      zoo.Dinosaurs.Add(new DinoClass { Name = "Raptor", Weight = 600, EnclosureNumber = 2, DietType = "Carnivore" });
      zoo.Dinosaurs.Add(new DinoClass { Name = "Triceritops", Weight = 700, EnclosureNumber = 1, DietType = "Herbivore" });

      bool dinoAnswer = true;
      while (dinoAnswer)
      {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("(VIEW ALL), (ADD), (REMOVE), (TRANSFER), (TOP HEAVY 3), (VIEW DIET), (QUIT)");

        var input = Console.ReadLine().ToLower();
        if (input == "view all")
        {
          zoo.DisplayDino();
        }
        else if (input == "add")
        {
          zoo.AddDino();
        }
        else if (input == "remove")
        {
          zoo.RemoveDino();

        }
        else if (input == "transfer")
        {
          Console.WriteLine("which Dinosaur?");
          var who = Console.ReadLine().ToLower();
          Console.WriteLine("which pen?");
          var newPen = Console.ReadLine().ToLower();
          zoo.Transfer(who, newPen);

        }
        else if (input == "top heavy 3")
        {
          zoo.GetThreeHeaviest();
        }
        else if (input == " view diet")
        {
          zoo.DinoDiet();
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