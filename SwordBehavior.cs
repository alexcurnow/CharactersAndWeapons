using System;

namespace CharactersAndWeapons
{
  public class SwordBehavior : IWeaponBehavior
  {
    public void useWeapon()
    {
      Console.WriteLine("A bastard sword slashes throught the air!");
    }
  }
}