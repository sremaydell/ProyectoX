using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Net;
namespace ProyectoX.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiControllers]

    public class UsuarioControllers : ControllerBase
    {
        private readonly IUsuarioRepositoy usuarioRepositoy;

        public UsuarioControllers(IUsuarioRepository usuarioRepository){

        }
        [HttpGet]
        public IActionResult Get(){
            var Usuario = this.UsuarioRepository.GetUsuario();

        }
        [HttpGet("{id}")]

        public IActionResult Get(int id){
            var Usu = this.UsuarioRepository.GetUsuarioById(id);
            try
            {
                Usu = this.usuarioRepositoy.GetUsuario(id);
            }
            catch (UsuarioException ex)
            {
                var result = new {Success = false, ErrorMessage = ex.Message};
                return BadRequest(result);
            }
            return Ok(Usu);
        }
        [HttpPost("Save")]
        public IActionResult Post([FromBody] UsuarioAdd usuarioAdd)
        {
            var result = this.UsuarioService.Save(usuarioAdd)
            this.UsuarioRepository.Add(new UsuarioControllers()
            {
                NombreCompleto = usuarioAdd.NombreCompleto,
                Correo = usuarioAdd.Correo,
                Clave = usuarioAdd.Clave
            
            });
            return Ok();
        }
            [HtpPost("Update")]

            public  IActioResult Put([FromBody] UsuarioUpdate usuarioUpdate)
            {
                Usuario usuarioToUpdate = new Usuario();
                this.usuarioRepository.Update(usuarioToUpdate);
                return Ok();

            }

            [HttpPost("Remove")]

            public IActionResult Delete([FromBody] UsuarioRemove usuarioRemove)
            {
                Usuario usuarioToDelete = new Usuario(){
                    Eliminado = usuarioRemove.Eliminado,
                    Estado = usuarioRemove.Estado,
                    FechaCreacion = usuarioRemove.FechaCreacion
                };
                this.usuarioReopository.Remove(usuarioToDelete);
                return Ok();
            }
        }



