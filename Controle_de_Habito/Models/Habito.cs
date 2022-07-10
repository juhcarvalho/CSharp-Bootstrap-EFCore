using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_de_Habito.Models
{
    [Table("Habito")]
    public class Habito
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage="O nome é obirgatório")]
        public String Nome { get; set; }

        [StringLength(200)]
        public String Objetivo { get; set; }

        [StringLength(10)]
        public string Dias { get; set; }

        public DateTime Horario { get; set; }

        public DateTime? DataInicio { get; set; }

    }
}
