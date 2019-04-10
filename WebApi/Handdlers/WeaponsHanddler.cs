using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi {
    public class WeaponsHanddler {
        public void CalculateImprovementOverWeapons (ref int score, List<EnumArmas> weaponsPlayer) {
            
            //NAAAAAAAAAAAAA
            //ESTO ES HORRIBLE. ALGUNA OTRA MANERA TIENE Q HABER

            //sON 3 RECURSIVOS.... ES MUY FEO...
            //TENGO Q PASAR LA LISTA DE IDS A LISTA DE OBJETOS Y MODIFICAR CADA OBJETO,
            //DESPUES MANDARLE LA LISTA DE OBJETOS A LAS HABILIDADES PORQ SINO NO PODRE MODIFICAR
            // CADA ARMA POR SI HABILIDAD.
            
            
            WeaponService dataBaseWeapons = new WeaponService ();
            for (int i = 0; i < weaponsPlayer.Count; i++) {

                var realWeapon = dataBaseWeapons.weapons.Find (weapon => weapon.ID == weaponsPlayer[i]);
                for (int j = 0; j < realWeapon.ModifiedWeapons.Count; j++) {

                    for (int m = 0; m < weaponsPlayer.Count; m++) {
                        var realWeapon2 = dataBaseWeapons.weapons.Find (weapon => weapon.ID == weaponsPlayer[i]);
                
                        //score=score+realWeapon2.Damage

                    }
                }
            }

            /*


for (int) weaponid in weaponsPlayer) {
            var weapon = dataBaseWeapons.weapons.Find (realWeapon => realWeapon.ID == weaponid);
            foreach (var modWeapon in weapon.ModifiedWeapons) {

            }
        }

if (realWeapon.CancelledWeapons.Contains (weaponsPlayer[j])) {
                        score=score+weaponsPlayer[i].
                    }

         */

        }
    }
}