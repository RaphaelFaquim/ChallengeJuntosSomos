using CodeChallengeJuntosSomos.Borders.Dtos;

namespace CodeChallengeJuntosSomos.Borders.Extensions
{
    public static class CVSToJSON
    {
        public static Insumo ConvertInsumoCsvToInsumo(this List<InsumoCsv> ListInsumoCsv)
        {
            var ListInsumo = new List<InsumoItem>();

            foreach (var itemInsumoCSV in ListInsumoCsv.ToList())
            {

                var insumoItem = new InsumoItem()
                {
                    Name = new Name()
                    {
                        First = itemInsumoCSV.Name__first,
                        Last = itemInsumoCSV.Name__last,
                        Title = itemInsumoCSV.Name__title,
                    },
                    Location = new Location()
                    {
                        City = itemInsumoCSV.Location__city,
                        Coordinates = new Coordinates() { Latitude = itemInsumoCSV.Location__coordinates__latitude, Longitude = itemInsumoCSV.Location__coordinates__longitude },
                        Postcode = int.Parse(itemInsumoCSV.Location__postcode),
                        State = itemInsumoCSV.Location__state,
                        Street = itemInsumoCSV.Location__street,
                        Timezone = new Timezone() { Description = itemInsumoCSV.Location__timezone__description, Offset = itemInsumoCSV.Location__timezone__offset },
                    },
                    Gender = itemInsumoCSV.Gender,
                    Email = itemInsumoCSV.Email,
                    Phone = itemInsumoCSV.Phone,
                    Cell = itemInsumoCSV.Cell,
                    Dob = new Dob() { Age = int.Parse(itemInsumoCSV.Dob__age), Date = DateTime.Parse(itemInsumoCSV.Dob__date) },
                    Picture = new Picture() { Large = itemInsumoCSV.Picture__large, Medium = itemInsumoCSV.Picture__medium, Thumbnail = itemInsumoCSV.Picture__thumbnail },
                    Registered = new Registered() { Age = int.Parse(itemInsumoCSV.Registered__age), Date = DateTime.Parse(itemInsumoCSV.Registered__date) },

                };
                ListInsumo.Add(insumoItem);
            }
            return new Insumo() { Results = ListInsumo };
        }
    }
}
