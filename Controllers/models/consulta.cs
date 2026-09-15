using System.Text.Json.Serialization;

namespace vettech.Controllers.models
{
    public class consulta
    {
        public int Id { get; set; }
        public DateTime dataHora { get; set; }
        public string motivo { get; set; }

    ´public int PetId { get; set; }
     public int veterinarioId { get; set; }

        [JsonIgnore]
        public pet? pet { get; set; }
        
        [JsonIgnore]
        public veterinario? veterinario { get; set; }
    }
}
