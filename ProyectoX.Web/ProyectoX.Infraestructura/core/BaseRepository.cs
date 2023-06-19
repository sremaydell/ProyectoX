

using ProyectoX.Domain.Repository;
using System.Collections.Generic;

namespace ProyectoX.Infraestructura.core
{
    public abstract class BaseRepository<Tentity> : IRepositoryBase<Tentity> where Tentity : class
    {
        public virtual  Tentity GetEntityById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public virtual List<Tentity> GetTentities()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Save(Tentity entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Update(Tentity entity)
        {
            throw new System.NotImplementedException();
        }
       

    }
}