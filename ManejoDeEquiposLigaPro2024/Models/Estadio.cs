using System.ComponentModel.DataAnnotations;

namespace ManejoDeEquiposLigaPro2024.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Direccion { get; set; }
        [MaxLength(50)]
        public string Ciudad { get; set; }
        [MaxLength(50)]
        public int Capacidad { get; set; }
    }
}
