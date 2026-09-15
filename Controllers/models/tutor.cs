namespace vettech.Controllers.models
{
    public class tutor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string telefone { get; set; }

        public ICollection<pet> pets{ get; set; } = new List<pet>();
    }
}
