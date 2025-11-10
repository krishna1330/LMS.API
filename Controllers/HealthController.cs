using LMS.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly LMSDbContext _context;

        public HealthController(LMSDbContext context)
        {
            _context = context;
        }

        [HttpGet("check")]
        public IActionResult CheckDatabaseConnection()
        {
            try
            {
                bool canConnect = _context.Database.CanConnect();

                if (canConnect)
                {
                    return Ok(new
                    {
                        status = "Healthy ✅",
                        database = "Connected",
                        timestamp = DateTime.Now
                    });
                }
                else
                {
                    return StatusCode(503, new
                    {
                        status = "Unhealthy ❌",
                        database = "Cannot connect to SQL Server",
                        timestamp = DateTime.Now
                    });
                }
            }
            catch (Exception ex)
            {
                // In case of SQL/network exceptions
                return StatusCode(500, new
                {
                    status = "Error ⚠️",
                    message = ex.Message,
                    timestamp = DateTime.Now
                });
            }
        }
    }
}
