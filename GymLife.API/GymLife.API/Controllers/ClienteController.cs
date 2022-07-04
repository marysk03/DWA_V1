using GymLife.API.Models;
using GymLife.DOMAIN.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymLife.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        [Route("get/{email}")]
        public async Task<IActionResult> GetOne(string correo)
        {
            using var data = new GymisLifeContext();
            ResponseClie response = null;
            var usuario = await data.Persona.Where(x => x.Correo == correo).FirstOrDefaultAsync();
            if (usuario == null)
            {
                response = new ResponseClie()
                {
                    Code = 400,
                    Msg = ""
                };
            }
            response = new ResponseClie()
            {
                Code = 200,
                Msg = "Usuario encontrado",
                Data = usuario
            };
            return Ok(response);
            //return Ok(usuario);
        }










        public IActionResult Login()
        {
            return View();
        }
    }
}
