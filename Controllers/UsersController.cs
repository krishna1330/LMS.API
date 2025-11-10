using LMS.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsers _userRepo;
        public UsersController(IUsers userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet("employees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _userRepo.GetAllEmployeesAsync();
            return Ok(employees);
        }
    }
}
