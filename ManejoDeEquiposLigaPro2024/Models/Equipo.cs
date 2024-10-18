using System.ComponentModel.DataAnnotations;

namespace ManejoDeEquiposLigaPro2024.Models
{
    public class Equipo
    {
       
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad {  get; set; }
        public int Titulos { get; set; }
        public bool AceptaExtranjeros {  get; set; }
        
    }
}
