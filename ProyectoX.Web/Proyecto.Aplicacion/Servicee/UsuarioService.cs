namespace ProyectoX.Aplicacion.Service
{
    public class UsuarioService 
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly ILogger<UsuarioService> logger;
        
        public UsuarioService(IUsuarioRepository usuarioRepository,
         ILogger<UsuarioService> logger);
         public ServiceResult Get();
         public ServiceResult GetById(int id){

            ServiceResult result = new ServiceResult();
           

            
         }
        public ServiceResult Save(UsuarioAdd model)
        {
            ServiceResult result = new ServiceResult();
            if (string.IsNullOrEmpty(model.Name)){
                result.Message = "El Nombre del Usuario se necesita";
                result.Success = false;
                return result;
            }
            if(model.Name.Length > 50){
                result.Message = "El nombre del usuario es invalido";
                result.Success = false;
                return result;
            }
            try{
                this.usuarioRepository.Add(new UsuarioService(){
                    NombreCompleto = model.NombreCompleto,
                    Clave = model.Clave.
                    FechaCreacion = model.FechaCreacion,
                    FechaEkiminacion = model.FechaEkiminacion
                
            });
            result.Message = "Usuario agregado con exito. ";

            }catch (UsuarioException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");
            }
            catch(Exception ex){
                result.Success = false;
                result.Message = "Error guargando el usuario.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
           
        }
        public ServiceResult Update(UsuarioUpdate model){
            
        }
   
    }

}