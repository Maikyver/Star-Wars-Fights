using System;
using System.Collections.Generic;
using WebApi;
using WebApi.Controllers;

namespace WebApi.Models {
    public class BattleHanddler {
        List<EnumArmas> weapons;
        List<Ability> abilities;

        /*
               TODO:
               *1.Cancelar Armas al enemigo
               *2.Que me cancele Armas el enemigo
               *3.calcular daño al enemigo            
               *4.calcular defensa del enemigo.
                   *calcular nivel de daño y defensa de las armas segun el planeta
               *5. Calcular score final.
                   *Gana quien tenga mas segun la diferencia entre ataque y defensa del otro
        */

        public BattleAnswer Battle () {
            AbilitiesService mockHabilities = new AbilitiesService ();
            BattleAnswer answer = new BattleAnswer ();
            List<EnumArmas> weaponsPlayer1 = new List<EnumArmas> ();
            List<EnumAbilities> habilitiesPlayer1 = new List<EnumAbilities> ();
            List<EnumArmas> weaponsPlayer2 = new List<EnumArmas> ();
            List<EnumAbilities> habilitiesPlayer2 = new List<EnumAbilities> ();

            CancelWeapons (weaponsPlayer1, weaponsPlayer2);
            CancelWeapons (weaponsPlayer2, weaponsPlayer1);

            return answer;
        }

        private void CancelWeapons (List<EnumArmas> weaponsPlayer1, List<EnumArmas> weaponsPlayer2) {
            WeaponService dataBaseWeapons = new WeaponService ();

            foreach (var weaponP1 in weaponsPlayer1) {

                foreach (var weaponP2 in weaponsPlayer2) {

                    Weapon realWeapon = dataBaseWeapons.weapons.Find (weapon => weapon.ID == weaponP1);
                    if (weaponsPlayer2.Contains (realWeapon.ID)) {

                        weaponsPlayer2.Remove(weaponP2);
                    }
                }
            }

        }

    }
}