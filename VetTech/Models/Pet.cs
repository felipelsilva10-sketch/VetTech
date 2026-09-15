using System.Text.Json.Serialization;

namespace VetTechApi.Models
{
    public class Pet
    { public int id { get; set; }
        public string nome { get; set; }
        public string especie { get; set; }
        public string raca { get; set; }
        public int tutorId { get; set; }
        [JsonIgnore]
        public Tutor? tutor { get; set; }
        public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}
