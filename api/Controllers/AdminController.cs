using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;

using api.Model;
using Microsoft.EntityFrameworkCore;
using api.Dtos;
using Microsoft.AspNetCore.Identity;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly NorthwindContext _context;
        private readonly UserManager<User> _userManager;

        public AdminController(NorthwindContext context, UserManager<User> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        [Authorize(Policy = "RequireAdminRole")]
        [HttpGet("userWithRoles")]
        public async Task<IActionResult> GetUserWithRoles()
        {
            var ruserList = await _context.Users
                .OrderBy(x => x.UserName)
                .Select(user => new
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Roles = (from userRole in user.UserRoles
                             join role in _context.Roles
                             on userRole.RoleId
                             equals role.Id
                             select role.Name).ToList()
                }).ToListAsync();

            return Ok(ruserList);
        }

        [Authorize(Policy = "RequireAdminRole")]
        [HttpGet("availableRoles")]
        public async Task<IActionResult> GetAvailableRoles()
        {
            var rolesList = await _context.Roles
                .OrderBy(x => x.Name)
                .Select(role => new
                {
                    name = role.Name,
                    value = role.Name
                }).ToListAsync();

            return Ok(rolesList);
        }

        [Authorize(Policy = "RequireAdminRole")]
        [HttpPost("editRoles/{userName}")]
        public async Task<IActionResult> EditRoles(string userName, RoleEditDto roleEditDto)
        {
            var user = await _userManager.FindByNameAsync(userName);

            var userRoles = await _userManager.GetRolesAsync(user);

            var selectedRoles = roleEditDto.RoleNames;

            selectedRoles = selectedRoles ?? new string[] {};
            var result = await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles));

            if (!result.Succeeded)
                return BadRequest("Failed to add to roles");

            result = await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles));

            if (!result.Succeeded)
                return BadRequest("Failed to remove the roles");

            return Ok(await _userManager.GetRolesAsync(user));

        }

        [Authorize(Policy = "HumanResourceRole")]
        [HttpGet("employeesInfo")]
        public IActionResult GetEmployeesInfo()
        {
            return Ok("Admins or Human Resource can see this");
        }
    }
}