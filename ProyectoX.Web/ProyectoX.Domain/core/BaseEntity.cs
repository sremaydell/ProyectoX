using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoX.Domain.core
{
    public abstract class BaseEntity
    {
        public BaseEntity()
            {
            this.FechaCreacion = DateTime.Now;
            this.Eliminado = false;
            }
        public int IdRolUsuario { get; set; }
        public string? Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEliminacion { get; set; }
        public bool Eliminado { get; set; }
        public string? AgregarUsuario { get; set; }
    }
}