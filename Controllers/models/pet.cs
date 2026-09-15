namespace vettech.Controllers.models
{
    public class pet
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string especie { get; set; }

        public int tutorId { get; set; }

        public ICollection<consulta> consulta { get; set; } = new List<consulta>();
    }
}
