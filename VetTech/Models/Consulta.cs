using System.Text.Json.Serialization;

namespace VetTechApi.Models
{
    public class Consulta
    { public int id { get; set; }
        public DateTime dataHora { get; set; }
        public string Motivo { get; set; }
        public int petId { get; set; }
        [JsonIgnore]
        public Pet? pet { get; set; }
        public int veterinarioId { get; set; }
        [JsonIgnore]
        public Veterinario? veterinario { get; set; }
    }
}
