using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public class Weapon
    {
        public string name { get; set; }
        public EnumArmas ID { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }

        public List<WeaponUpgrades> ModifiedWeapons { get; set; }
        public List<EnumArmas> CancelledWeapons { get; set; }
        static public List<string> names = new List<string>() { "Bow", "Force", "Knife", "Laser Gun", "Shield", "Laser Saber" };

    }
}
