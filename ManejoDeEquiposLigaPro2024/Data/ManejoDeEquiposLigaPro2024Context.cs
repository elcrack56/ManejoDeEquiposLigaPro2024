using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManejoDeEquiposLigaPro2024.Models;

namespace ManejoDeEquiposLigaPro2024.Data
{
    public class ManejoDeEquiposLigaPro2024Context : DbContext
    {
        public ManejoDeEquiposLigaPro2024Context (DbContextOptions<ManejoDeEquiposLigaPro2024Context> options)
            : base(options)
        {
        }

        public DbSet<ManejoDeEquiposLigaPro2024.Models.Jugador> Jugador { get; set; } = default!;
        public DbSet<ManejoDeEquiposLigaPro2024.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<ManejoDeEquiposLigaPro2024.Models.Estadio> Estadio { get; set; } = default!;
    }
}
