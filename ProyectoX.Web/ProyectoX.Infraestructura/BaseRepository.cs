

using Hotel.Infraestrutura.repository;

namespace Hotel.Infraestrutura.core
{
   public abstract class BaseRepository<Tentity> :IRepositoryBase<Tentity>  where Tentity : class
    {
        public Tentity GetEntityById(int Id)
        {
            throw new System.NotImplementedException();
        }
        public void Save(Tentity entity)
        {
            throw new System.NotImplementedException();
        }
        
        public void Update(Tentity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
