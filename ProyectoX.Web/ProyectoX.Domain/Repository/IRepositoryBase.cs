

using ProyectoX.Domain.core;
using ProyectoX.Domain.Entities;
using System.Collections.Generic;

namespace ProyectoX.Domain.Repository
{
    public interface IRepositoryBase<Tentity> where Tentity : class, new() 
    {
        void Save(Tentity entity);
        void Update(Tentity entity);
        Tentity GetEntityById(int Id);

        List<Tentity> GetTentities();

    }
}