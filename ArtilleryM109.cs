﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFproject_2105
{
    internal class ArtilleryM109: IWapons, IAmmunition, IEffectiveAgainst, IEnergyBalance , ITypeOfBomb, ILeftAtacks
    {

        string Name = "shell.";
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
        public int GetILeftAtacks(int num)
        {
            return num;
        }
    }
}
