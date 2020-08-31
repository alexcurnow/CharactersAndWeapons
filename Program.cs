using System;

namespace CharactersAndWeapons
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight artorius = new Knight();
            artorius.fight();
            artorius.battle();
            artorius.setWeapon(new AxeBehavior());
            artorius.battle();
        }
    }
}