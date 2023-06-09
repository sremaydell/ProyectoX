using Hotel.Infraestrutura.repository;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Hotel.Infraestrutura.context
{
    public partial class HotelContext : DbContext
    {
        public HotelContext()
        {

        }
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)



    public DbSet<Usuario> Usuario { get; set; }

    }
}
