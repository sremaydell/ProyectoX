namespace ProyectoX.Infraestructura.interfaces 
{
public interface IUsuarioRepository : IRepositoryBase<Usuario>
{
   public List<Usuario> GetUsuarioByRolUsuario(int IdRolUsuario);
}
}