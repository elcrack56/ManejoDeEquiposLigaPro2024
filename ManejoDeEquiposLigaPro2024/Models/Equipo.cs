using System.ComponentModel.DataAnnotations;

namespace ManejoDeEquiposLigaPro2024.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Ciudad {  get; set; }
        [MaxLength(20)]
        public int Titulos { get; set; }
        public bool AceptaExtranjeros {  get; set; }
        
    }
}
