using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManejoDeEquiposLigaPro2024.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Posicion { get; set; }
        [Range(14, 40)]
        public int Edad { get; set; }
        public Equipo? equipos { get; set; }

        [ForeignKey(nameof(equipos))]
        public int equiposId { get; set; }

    }
}
