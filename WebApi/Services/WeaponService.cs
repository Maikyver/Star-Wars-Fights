using System;
using System.Collections.Generic;
using WebApi.Models;


namespace WebApi
{
    public class WeaponService
    {
        public List<Weapon> weapons = new List<Weapon>();
        public WeaponService() //Pregeneradas
        {
            Weapon weapon = new Weapon() {ID = EnumArmas.BOW,Damage= 75, Defense=25, 
                    CancelledWeapons = new List<EnumArmas>(){EnumArmas.KNIFE},
                    ModifiedWeapons = new List<WeaponUpgrades>(){},
                    name = Weapon.names[(int)EnumArmas.BOW]};
            weapons.Add(weapon);
            weapon = new Weapon() {ID = EnumArmas.FORCE,Damage= 150, Defense=80,
                    CancelledWeapons = new List<EnumArmas>(){EnumArmas.SHIELD,EnumArmas.KNIFE},
                    ModifiedWeapons = new List<WeaponUpgrades>()
                        {
                            new WeaponUpgrades(EnumArmas.LASERSABER,15,15)
                        },
                    name = Weapon.names[(int)EnumArmas.LASERSABER]};
            weapons.Add(weapon);
            weapon = new Weapon() {ID = EnumArmas.KNIFE,Damage= 40, Defense=25,
                    CancelledWeapons = new List<EnumArmas>(),
                    ModifiedWeapons = new List<WeaponUpgrades>(){},
                    name = Weapon.names[(int)EnumArmas.KNIFE]};
            weapons.Add(weapon);
            weapon = new Weapon() {ID = EnumArmas.LASERGUN,Damage= 125, Defense=25,
                    CancelledWeapons = new List<EnumArmas>(){EnumArmas.KNIFE},
                    ModifiedWeapons = new List<WeaponUpgrades>(){},
                    name = Weapon.names[(int)EnumArmas.LASERGUN]};
            weapons.Add(weapon);
            weapon = new Weapon() {ID = EnumArmas.SHIELD,Damage= 10, Defense=150,
                    CancelledWeapons = new List<EnumArmas>(){EnumArmas.KNIFE},
                    ModifiedWeapons = new List<WeaponUpgrades>()
                        {
                            new WeaponUpgrades(EnumArmas.LASERSABER,0,20)
                        },
                    name = Weapon.names[(int)EnumArmas.SHIELD]};
            weapons.Add(weapon);
            weapon = new Weapon(){ID = EnumArmas.LASERSABER,Damage= 150, Defense=125,
                    CancelledWeapons = new List<EnumArmas>(){EnumArmas.BOW,EnumArmas.SHIELD,EnumArmas.KNIFE,EnumArmas.LASERGUN},
                    ModifiedWeapons = new List<WeaponUpgrades>()
                        {
                            new WeaponUpgrades(EnumArmas.KNIFE,5,0)
                        },
                    name = Weapon.names[(int)EnumArmas.LASERSABER]};
            weapons.Add(weapon);
        }
        private void UpgradeWeapon () // Crear este metodo cuando haya habilidades
        {
        }
        public Weapon one (int id){ return(weapons[id]);  }
    }
}