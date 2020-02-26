using System;

namespace JurassicPark
{
  public class DinoClass
  {
    public string Name { get; set; }
    public string DietType { get; set; }
    public DateTime DateAcquired { get; set; } = DateTime.Now;
    public int Weight { get; set; }
    public int EnclosureNumber { get; set; }

  }
}