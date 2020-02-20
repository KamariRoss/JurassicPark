using JurassicPark;
using JurassicPark Collections.Generic

{
  public class DinoString
{
  public List<DinoClass> Classes { get; set; } = new List<DinoClass>();

  public void AddANewString(string DinoName, string DinoDiet, string Pounds, string Number, )
  {
    var DinoClass = new DinoClass
    {
      Name = DinoName,
      DietType = DinoDiet,
      DateAcquired = Datetime.now
        Weight = Pounds,
      EnclosureNumber = Number,
    };
    Classes.Add(DinoClass);
  }
}
}