using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace encuesta2025.Models
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; } = string.Empty;
        public int IdGenero { get; set; }
        [ForeignKey("IdGenero")]
        public virtual Genero Genero { get; set; }
        public string Grado { get; set;} = string.Empty;
        public string Sede { get; set;} = string.Empty;
    }
}
