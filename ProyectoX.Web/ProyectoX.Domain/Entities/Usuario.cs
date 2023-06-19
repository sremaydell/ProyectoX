using ProyectoX.Domain.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoX.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public int  IdUsuario {get; set;}
        public string? NombreCompleto { get; set; }
        public string? Correo { get; set; }
        public  string? Clave { get; set; }
       
    }
}