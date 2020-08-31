using System;

namespace CharactersAndWeapons
{
  public class AxeBehavior : IWeaponBehavior
  {
    public void useWeapon()
    {
      Console.WriteLine("A heavy axe cleaves down from the sky!");
    }
  }
}