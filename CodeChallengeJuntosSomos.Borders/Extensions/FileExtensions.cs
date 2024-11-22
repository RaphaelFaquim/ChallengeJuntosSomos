
using CodeChallengeJuntosSomos.Borders.Dtos;

namespace CodeChallengeJuntosSomos.Borders.Extensions
{
    public class FileExtensions
    {

        public Insumo ConverterCSVParaObjeto(string InsumoCsv)
        {

           return new Insumo() { Results = []};

        }
    }
}
