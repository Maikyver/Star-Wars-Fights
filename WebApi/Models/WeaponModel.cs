using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public class Weapon {
       public EnumArmas IdTipoDeArma { get; set; }
       public int Daño { get; set; }
       public int Defensa { get; set; }

       List<WeaponUpgrades> ArmasQueModifico { get; set; }
       List<EnumArmas> ArmasQueCancelo { get; set; }
       void UpgradeWeapon (ref List<Weapon> armas)
       {

       }
   }
}
