using System;
using System.Collections.Generic;
using WebApi;
using WebApi.Controllers;

namespace WebApi.Models {
    public class BattleHanddler {
        List<EnumArmas> weapons;
        List<Ability> habilities;

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
            AbilitiesService mockHabilities= new AbilitiesService();
            BattleAnswer answer = new BattleAnswer ();
            List<EnumArmas> weaponsPayer1 = new List<EnumArmas> ();
            List<EnumAbilities> habilitiesPlayer1 = new List<EnumAbilities> ();
            List<EnumArmas> weaponsPayer2 = new List<EnumArmas> ();
            List<EnumAbilities> habilitiesPlayer2 = new List<EnumAbilities> ();

            CancelWeapons (weaponsPayer1, weaponsPayer2);

            return answer;
        }

        private void CancelWeapons (List<EnumArmas> weaponsPayer1, List<EnumArmas> weaponsPayer2) {
            
        }

    }

}