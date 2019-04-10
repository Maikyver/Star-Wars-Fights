using System;

namespace WebApi.Models
{
    public class BattleAnswer
    {
        public int WinnersId { get; set; }

        public int ScoreMade { get; set; }

        public BattleAnswer(int id, int score)
        {
            WinnersId=id;
            ScoreMade=score;
            
        }
    }
}