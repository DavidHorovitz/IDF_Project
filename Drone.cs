using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFproject_2105
{
    internal class Drone : IWapons, IAmmunition, IEffectiveAgainst, IEnergyBalance, ITypeOfBomb
    {
        string[] Name = { "Depence" };
        public string NameOfWapon(string name)
        {

            return name;
        }

        public string NameOfAmmunition(string name)
        {

            return name;
        }

        public string NameOfTargt(string[] names)
        {

            return names[0];
        }
        public int LeftEnergyBalance(int num)
        {

            return num;
        }
        public string GetTypeOfBomb(string name)
        {
            return name;
        }

    }
}
