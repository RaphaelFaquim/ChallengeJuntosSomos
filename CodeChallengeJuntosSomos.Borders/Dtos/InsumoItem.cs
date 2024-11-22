
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
namespace CodeChallengeJuntosSomos.Borders.Dtos
{
    public class InsumoItem
    {
        //public required string Gender { get; set; }
        private string? _Gender;
        public string? Gender
        {
            get => _Gender;
            set
            {
                _Gender = value.Remove(1).ToUpper();
            }
        }
        public required Name Name { get; set; }
        public required Location Location { get; set; }
        public required string Email { get; set; }
        //[JsonIgnore]
        public required Dob Dob { get; set; }
        //[JsonIgnore]
        public required Registered Registered { get; set; }
        public required string _Phone;
        public required string Phone
        {
            get => _Phone;
            set
            {
                _Phone = "+55" + Regex.Replace(value, @"[^\d]", "");
            }
        }
        public required string _Cell;
        public required string Cell
        {
            get => _Cell;
            set
            {
                _Cell = "+55" + Regex.Replace(value, @"[^\d]", "");
            }
        }
        public required Picture Picture { get; set; }
        public string? _Nationality; 
        public string? Nationality 
        {
            get => _Nationality;
            set
            {
                _Nationality = "BR";
            }
        }
    }
}
