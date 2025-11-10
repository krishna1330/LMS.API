using LMS.API.Data;
using LMS.API.Models;
using LMS.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LMS.API.Repositories.Implementations
{
    public class UsersRepo : IUsers
    {
        private readonly LMSDbContext _dbcontext;

        public UsersRepo(LMSDbContext context)
        {
            _dbcontext = context;
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
        {
            try
            {
                var employees = await _dbcontext.Users
                    .Where(u => u.UserType == "Employee" && !u.IsDeleted)
                    .Select(u => new EmployeeDto
                    {
                        UserId = u.UserId,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Email = u.Email,
                        IsActive = u.IsActive
                    })
                    .ToListAsync();

                return employees;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving employees", ex);
            }
        }
    }
}