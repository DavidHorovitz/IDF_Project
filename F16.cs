using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFproject_2105
{
    internal class F16 : IWapons, IAmmunition, IEffectiveAgainst, IEnergyBalance, ITypeOfBomb
    {
        string Name = "1 ton or 0.5 ton";

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
