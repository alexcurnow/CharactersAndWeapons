using System;

namespace CharactersAndWeapons
{
  public class Knight : Character
  {
    public Knight()
    {
      weapon = new SwordBehavior();
    }
    public override void fight()
    {
      Console.WriteLine("The knight engages in battle.");
    }
  }
}