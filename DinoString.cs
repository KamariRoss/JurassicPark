using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
  public class DinoString
  {
    public List<DinoClass> Dinosaurs { get; set; } = new List<DinoClass>();
    public void AddDino()
    {
      //declare variables & ask for User Input
      Console.WriteLine($"What is the name of dinosaur?");
      var name = Console.ReadLine().ToLower();

      // Get input
      Console.WriteLine("Is your dinosaur a herbivore or carnivore?");
      var dietInput = Console.ReadLine();
      if (dietInput != "herbivore" || dietInput != "carnivore")
        // user validation
        Console.WriteLine("What is the weight of your Dinosour in pounds?");
      var weight = int.Parse(Console.ReadLine());
      Console.WriteLine("What is the enclosureNumber of your Dinosour in pounds?");
      var enclosureNumber = int.Parse(Console.ReadLine());
      //add it to the list


      Dinosaurs.Add(new DinoClass { Name = name, Weight = weight, EnclosureNumber = enclosureNumber, DietType = dietInput });

    }
    public void Transfer(string who, string newPen)
    {
      // find the item in the list 
      var dino = Dinosaurs.First(DinoClass => DinoClass.Name == who);
      // re-assign the fields
      dino.EnclosureNumber = int.Parse(newPen);
    }
    // taking the heaviest three
    public void DisplayDino()
    {
      var FullDinoList = Dinosaurs.OrderByDescending(dino => dino.DateAcquired);
      foreach (var dino in FullDinoList)
      {
        Console.WriteLine($"The dino is {dino.Name},its weight is {dino.Weight}, its enclosure is {dino.EnclosureNumber}, its a {dino.DietType}, it was added{dino.DateAcquired}.");
      }
    }
    public void GetThreeHeaviest()
    {
      var heaviest = Dinosaurs.OrderByDescending(dino => dino.Weight).Take(3);
      foreach (var dino in heaviest)
      {
        Console.WriteLine($"The {dino.Name} weight is {dino.Weight} ");
      }
    }

    public void DinoDiet()
    {
      var DinoDietDisplay = Dinosaurs.OrderByDescending(dino => dino.DateAcquired);
      foreach (var dino in DinoDietDisplay)
      {
        Console.WriteLine($"The dino {dino.Name},is a {dino.DietType}.");
      }

    }
    public void RemoveDino()
    {
      Console.WriteLine("What would you like to remove?");
      Console.Write("Please type there name");
      var DinoDelete = Console.ReadLine().ToLower();
      var DinoFind = Dinosaurs.First(dino => dino.Name.ToLower().Contains(DinoDelete));
      Console.WriteLine($"Dear user we found a Dinosour named {DinoFind.Name}");
      Dinosaurs.Remove(DinoFind);
      // where, any, first, single, take, findindex
      // remove, remove at
    }
  }
}