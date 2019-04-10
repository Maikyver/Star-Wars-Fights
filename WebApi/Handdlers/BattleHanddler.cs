using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WebApi.Models;
using WebApi.Controllers;

namespace WebApi{

    public class BattleHanddler {
        WeaponsHanddler weaponsHanddler=new WeaponsHanddler();
        /*
               TODO:
               *1.Cancelar Armas al enemigo -done-
               *2.Que me cancele Armas el enemigo -done-
               *3.calcular daño al enemigo            
               *4.calcular defensa del enemigo.
                   *calcular nivel de daño y defensa de las armas segun el planeta
               *5. Calcular score final.
                   *Gana quien tenga mas segun la diferencia entre ataque y defensa del otro
        */

        public BattleAnswer Battle (String data) {

            var mock = @" {
                       'player1':{
                                    'Id':1,
                                    'Weapons':[1,2],
                                    'Abilities':[1,2],
                                    },
                         'player2':{
                                    'Id':2,
                                    'Weapons':[2,4],
                                    'Abilities':[1,2],
                                    },
                        'planet':1           
                   }";

            var battleMock = JsonConvert.DeserializeObject<OneOnOneFightData> (mock);
            CancelWeapons (battleMock.player1.weapons, battleMock.player2.weapons);
            CancelWeapons (battleMock.player2.weapons, battleMock.player1.weapons);
            CalculateHarm(battleMock);
            BattleAnswer answer = new BattleAnswer (1, 300);
            return answer;
        }

        private void CancelWeapons (List<EnumArmas> weaponsPlayer1, List<EnumArmas> weaponsPlayer2) {

            WeaponService dataBaseWeapons = new WeaponService ();

            for (int i = 0; i < weaponsPlayer1.Count; i++) {
                Weapon realWeapon = dataBaseWeapons.weapons.Find (weapon => weapon.ID == weaponsPlayer1[i]);
                for (int j = weaponsPlayer2.Count - 1; j >= 0; j--) {

                    if (realWeapon.CancelledWeapons.Contains (weaponsPlayer2[j])) {
                        weaponsPlayer2.Remove (weaponsPlayer2[j]);
                    }

                }
            }

        }
        private int CalculateHarm (OneOnOneFightData battle) {
            int score=0;

            weaponsHanddler.CalculateImprovementOverWeapons (ref score,battle.player1.weapons);
            //CalculateImprovementOverAbility(ref score,battle.player1.weapons,battle.player1.abilities);
            //CalculateImprovementOverHomePlanet(ref score,battle.player1.id,battle.planet);

            return score;
        }


    }
}