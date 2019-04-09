using System;
using System.Collections.Generic;
using WebApi.Models;


namespace WebApi
{
    public class AbilitiesService : IAbilitiesService
    {
        public List<Ability> abilities = new List<Ability>();
        public AbilitiesService()
        {
            Ability hab = new Ability() { ID = EnumAbilities.FORCE_CRUSH, Damage = 10, Defense = 4,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.FORCE,EnumArmas.LASERSABER},
                    name = Ability.names[(int)EnumAbilities.FORCE_CRUSH]
                    };
            abilities.Add(hab);
            hab = new Ability() { ID = EnumAbilities.CULLING_BLADE, Damage = 15, Defense = 8,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.FORCE,EnumArmas.LASERSABER},
                    name = Ability.names[(int)EnumAbilities.CULLING_BLADE]
                    };
            abilities.Add(hab);
            hab = new Ability() { ID = EnumAbilities.OLD_JEDI_KNIGHT, Damage = 11, Defense = 15,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.FORCE,EnumArmas.LASERSABER},
                    name = Ability.names[(int)EnumAbilities.OLD_JEDI_KNIGHT]
                    };
            abilities.Add(hab);
            hab = new Ability() { ID = EnumAbilities.QUICK_SHOT, Damage = 5, Defense = 0,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.BOW,EnumArmas.LASERGUN},
                    name = Ability.names[(int)EnumAbilities.QUICK_SHOT]
                    };
            abilities.Add(hab);
            hab = new Ability() { ID = EnumAbilities.PROTECTIVE_MANEUVER, Damage = 4, Defense = 15,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.FORCE,EnumArmas.LASERSABER,EnumArmas.SHIELD},
                    name = Ability.names[(int)EnumAbilities.PROTECTIVE_MANEUVER]
                    };
            abilities.Add(hab);
            hab = new Ability() { ID = EnumAbilities.BLAST_SMASH, Damage = 12, Defense = 3,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.SHIELD,EnumArmas.LASERSABER,EnumArmas.LASERSABER},
                    name = Ability.names[(int)EnumAbilities.BLAST_SMASH]
                    };
            abilities.Add(hab);
        }
    }
}
