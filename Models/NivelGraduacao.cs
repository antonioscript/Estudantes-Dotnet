using System.Text.Json.Serialization;
namespace Estudantes_Dotnet.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NivelGraduacao
    {
        Bacharelado = 1,
        Licenciatura = 2, 
        Tecnólogo = 3
    }
}