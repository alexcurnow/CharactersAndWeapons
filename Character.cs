using System;

namespace CharactersAndWeapons
{
  public abstract class Character
  {
    public IWeaponBehavior weapon;
    public void setWeapon(IWeaponBehavior w)
    {
      weapon = w;
    }
    public abstract void fight();
    public void battle()
    {
      weapon.useWeapon();
    }
  }
}