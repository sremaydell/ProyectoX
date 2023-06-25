using System.Runtime.Intrinsics.X86;
using System;
namespace ProyectoX.Aplicacion.Servicee
{
    public class    RolUsuarioService : IRolUsuarioService
    {
        private readonly IRolUsuarioRepository rolUsuarioRepository;
        private readonly ILooger<RolUsuarioService> looger;

        public     RolUsuarioService(IRolUsuarioRepository rolUsuarioRepository, ILogger<RolUsuarioService> logger){
            this.rolusuarioRepository = rolUsuarioRepository;
            this.looger = looger;
     }
    public ServiceResult Get(){
        ServiceResult result = new ServiceResult();
        try
        {
            var RolUsuario = this.rolUsuarioRepository.GetRolUsuario();
         result.Data = rolUsuario;
        }   
        catch (Exception ex)
        {
            result.Success = false;
            result.Message = "Error obteniendo los Roles";
            this.looger.LogError("", ex.ToString());
        }
        return result;
            }
             public ServiceResult GetById(int id){
                
            }

             public ServiceResult Remove(RolUsuarioRemove model){
        throw new System.NotImplementedException();
            }
             public ServiceResult Save(RolUsuarioAdd model){
                 ServiceResult result = new ServiceResult();
            if (string.IsNullOrEmpty(model.Name)){
                result.Message = "El Nombre del RolUsuario se necesita";
                result.Success = false;
                return result;
            }
            if(model.Name.Length > 50){
                result.Message = "El nombre del Rolusuario es invalido";
                result.Success = false;
                return result;
            }
            try
            {
                this.rolUsuarioRepository.Add(new RolUsuarioService(){
                    IdRolUsuario = model.IdRolUsuario,
                    Descripcion = model.Descripcion,
                    FechaCreacion = model.FechaCreacion,
                    FechaEkiminacion = model.FechaEkiminacion
                
            });
            result.Message = "RolUsuario agregado con exito. ";

            }catch (RolUsuarioException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");
            }
            catch(Exception ex){
                result.Success = false;
                result.Message = "Error guargando el Rolusuario.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
             }
             public ServiceResult Update(RolUsuarioUpdate model){
                 throw new System.NotImplementedException();
            }
    }
             }
    }
}