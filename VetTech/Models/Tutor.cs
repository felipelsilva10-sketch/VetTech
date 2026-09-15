namespace VetTechApi.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telefone { get; set; }
        public ICollection<Pet> Pets { get; set; } = new List<Pet>();
    }
}
