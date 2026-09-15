using System.Collections;

namespace vettech.Controllers.models
{
    public class veterinario
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string crmv { get; set; }
        public string especialidade { get; set; }

        public ICollection<consulta> consulta { get; set; } = new List<consulta>();
      
    }
}
