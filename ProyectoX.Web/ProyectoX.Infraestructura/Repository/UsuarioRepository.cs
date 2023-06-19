using ProyectoX.Domain.Entities;
using ProyectoX.Domain.Repository;
using ProyectoX.Infraestructura.core;
using System.Collections.Generic;

namespace ProyectoX.Infraestructura.Repositories
{
    public  class UsuarioRepositories : BaseRepository <Usuario>, IRepositoryBase
    {
        public List<Usuario> GetUsuarioByRolUsuario(int IdRolUsuario){
            throw new System.NotImplementedException();
        }
    }
}