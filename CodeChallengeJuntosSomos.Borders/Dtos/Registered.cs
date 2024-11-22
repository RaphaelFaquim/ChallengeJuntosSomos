
using System.Text.Json.Serialization;

namespace CodeChallengeJuntosSomos.Borders.Dtos
{
    public class Registered
    {
        public DateTime Date { get; set; }
        //[JsonIgnore]
        public int Age { get; set; }
    }
}
