using System.ComponentModel.DataAnnotations;

namespace financasApi.Models
{
    public class CadastroConta
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public string NumeroAgencia { get; set; }
        [MaxLength(30)]
        public string NumeroConta { get; set; }
    }
}
