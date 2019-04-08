using System;
using System.Collections.Generic;
using WebApi.Models;


namespace WebApi
{
    public class HabilitiesService : IHabilitiesService
    {
        public List<Habilitie> habilities = new List<Habilitie>();
        public HabilitiesService()
        {
            Habilitie hab = new Habilitie() { ID = EnumHabilidades.FORCE_CRUSH, Damage = 10, Defense = 4,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.FORCE,EnumArmas.LASERSABER},
                    name = Habilitie.names[(int)EnumHabilidades.FORCE_CRUSH]
                    };
            habilities.Add(hab);
            hab = new Habilitie() { ID = EnumHabilidades.CULLING_BLADE, Damage = 15, Defense = 8,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.FORCE,EnumArmas.LASERSABER},
                    name = Habilitie.names[(int)EnumHabilidades.CULLING_BLADE]
                    };
            habilities.Add(hab);
            hab = new Habilitie() { ID = EnumHabilidades.OLD_JEDI_KNIGHT, Damage = 11, Defense = 15,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.FORCE,EnumArmas.LASERSABER},
                    name = Habilitie.names[(int)EnumHabilidades.OLD_JEDI_KNIGHT]
                    };
            habilities.Add(hab);
            hab = new Habilitie() { ID = EnumHabilidades.QUICK_SHOT, Damage = 5, Defense = 0,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.BOW,EnumArmas.LASERGUN},
                    name = Habilitie.names[(int)EnumHabilidades.QUICK_SHOT]
                    };
            habilities.Add(hab);
            hab = new Habilitie() { ID = EnumHabilidades.PROTECTIVE_MANEUVER, Damage = 4, Defense = 15,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.FORCE,EnumArmas.LASERSABER,EnumArmas.SHIELD},
                    name = Habilitie.names[(int)EnumHabilidades.PROTECTIVE_MANEUVER]
                    };
            habilities.Add(hab);
            hab = new Habilitie() { ID = EnumHabilidades.BLAST_SMASH, Damage = 12, Defense = 3,
                    toUpgrade= new List<EnumArmas>(){EnumArmas.SHIELD,EnumArmas.LASERSABER,EnumArmas.LASERSABER},
                    name = Habilitie.names[(int)EnumHabilidades.BLAST_SMASH]
                    };
            habilities.Add(hab);
        }
    }
}
