using System.Runtime.Intrinsics.X86;
using Microsoft.AspNetCore.Mvc;


namespace ProyectoX.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolUsuarioController : ControllerBase
    {
        private readonly IRolUsuarioRepository rolusuarioRepository;
        public RolUsuarioController(IRolUsuarioRepository rolUsuarioRepository){
            this.rolusuarioRepository = rolUsuarioRepository;
        }
        [HttpGet("GetRolUsuario")]
        public IActionResult Get()
        {
            var result = this.rolusuarioService.Get();

            if (!result.Success)
                return BadRequest(result);
            

            return Ok(RolUsuario);
        }
        
        
        [HttpGet("{id}")]
        public string Get(int id)
        {

            return Ok();

            return "value";
        }

      
        [HttpPut("{Update}")]
        public void Put( [FromBody] RolUsuario rolUsuario)
        {
            this.rolusuarioRepository.Update(rolUsuario);
            return Ok();
        }
        

        [HttpDelete("{Remove}")]
        public void Delete([FromBody] RolUsuarioRemove rolusuarioRemove)
        {
            
                RolUsuario RolusuarioToDelete = new RolUsuario(){
                    Eliminado = rolusuarioRemove.Eliminado,
                    Estado = rolusuarioRemove.Estado,
                    FechaCreacion = rolusuarioRemove.FechaCreacion
                };
                this.rolusuarioReopository.Remove(rolusuarioToDelete);
                return Ok();
        }
    }
}
