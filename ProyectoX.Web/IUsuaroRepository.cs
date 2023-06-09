using Hotel.Infraestrutura.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Infraestrutura.interfaces
{
    public interface IUsuaroRepository :   IRepositoryBase<Usuario>, IUsuaroRepository
    {
public List<Usuario> GetUsuarioByUsuario(int Ussuario)
        {
            throw new System.NotImplementedException();
        }
       
    }
}
