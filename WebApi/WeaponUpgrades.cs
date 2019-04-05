using System;
using WebApi.Models;

namespace WebApi {
   public class WeaponUpgrades {
       public EnumArmas IdArma { get; set; }
       public int ValorModificaDaño { get; set; }
       public int ValorModificaDefensa { get; set; }

       public WeaponUpgrades (EnumArmas idArma, int valorModificaDaño, int valorModificaDefensa) 
       {
           IdArma = idArma;
           ValorModificaDaño = valorModificaDaño;
           ValorModificaDefensa = valorModificaDefensa;
       }

       public Weapon UpgradeWeapon( Weapon arma)
       {
           arma.Daño=arma.Daño+(arma.Daño*ValorModificaDaño);
           arma.Defensa=arma.Defensa+(arma.Defensa*ValorModificaDefensa);
           return arma;
       }
   }
}