using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; //para el actionResult

namespace WebApi.Models {
    public class Player1 {
        public int id { get; set; }
        public List<EnumArmas> weapons { get; set; }
        public List<EnumAbilities> abilities { get; set; }
    }

    public class Player2 {
        public int id { get; set; }
        public List<EnumArmas> weapons { get; set; }
        public List<EnumAbilities> abilities { get; set; }
    }

    public class RootObject {
        public Player1 player1 { get; set; }
        public Player2 player2 { get; set; }
        public int planet { get; set; }
    }

}