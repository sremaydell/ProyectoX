using System;
namespace ProyectoX.Aplicacion.Dto.Usuario
{
    public abstract class    UsuarioDto :DtoBase{
        public string NombreCompleto{get; set;}
        public DateTime FechaCreacion{get; set;}
        public DateTime FechaEliminacion { get; set; }
         public bool Eliminado { get; set; }
        public string? AgregarUsuario { get; set; }
    }
}