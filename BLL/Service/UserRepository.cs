using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BLL.Entities;
using BLL.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllAsync() => await _userManager.Users.ToListAsync();
        public async Task<ApplicationUser> GetByIdAsync(string id) => await _userManager.FindByIdAsync(id);
        public async Task<ApplicationUser> GetByEmailAsync(string email) => await _userManager.FindByEmailAsync(email);
        public async Task AddAsync(ApplicationUser user) => await _userManager.CreateAsync(user);
        public async Task UpdateAsync(ApplicationUser user) => await _userManager.UpdateAsync(user);
        public async Task DeleteAsync(string id) { var user = await _userManager.FindByIdAsync(id); if (user != null) await _userManager.DeleteAsync(user); }
    }
}
