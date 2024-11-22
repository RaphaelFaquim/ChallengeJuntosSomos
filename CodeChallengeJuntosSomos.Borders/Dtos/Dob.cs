
using System.Text.Json.Serialization;

namespace CodeChallengeJuntosSomos.Borders.Dtos
{
    public class Dob
    {
        public DateTime Date { get; set; }
        [JsonIgnore]
        public int Age { get; set; }
    }
}
