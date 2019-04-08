using System.Collections.Generic;

namespace WebApi.Models
{


    public class GetCharacters
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Character> results { get; set; }
    }

}