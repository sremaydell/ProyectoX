using Microsoft.EntityFrameworkCore;
using ProyectoX.Domain.Entities;

namespace ProyectoX.Infraestructura.Context
{
    public partial  class ProyectoXContext : DbContext
    {
        public ProyectoXContext()
        {

        }
        public ProyectoXContext(DbContextOptions<ProyectoXContext> options ): base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<RolUsuario> RolUsuarios { get; set; }
    }
}