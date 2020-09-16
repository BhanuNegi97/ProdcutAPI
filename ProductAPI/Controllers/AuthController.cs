using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using ProductAPI.DTO;
using ProductAPI.Model;
using ProductAPI.Repository;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepo = authRepository;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserDTO request)
        {
            try
            {
                ServiceResponse<int> response = await _authRepo.Register(
                   new User { Username = request.Username }, request.Password);
                if (!response.success)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
           
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserDTO request)
        {
            try
            {
                ServiceResponse<string> response = await _authRepo.Login(
                request.Username, request.Password);
                if (!response.success)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
            
        }

    }
}
