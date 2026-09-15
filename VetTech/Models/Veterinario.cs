namespace VetTechApi.Models
{
    public class Veterinario
    { public int Id { get; set; }
        public string Name { get; set; }
        public string Crmv { get; set; }
        public string Especialidade { get; set; }
        public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}
