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
            return Ok();
        }

        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return Ok();
        }

        
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

      
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
