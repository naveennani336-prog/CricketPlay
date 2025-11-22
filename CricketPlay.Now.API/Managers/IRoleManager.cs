using CricketPlay.Now.API.Models;

namespace CricketPlay.Now.API.Managers
{
    public interface IRoleManager
    {
        Task<bool> InsertRoleAsync(Role role);
        Task<bool> UpdateRoleAsync(Role role);
        Task<bool> DeleteRoleAsync(long roleId);
        Task<Role> GetRoleByIdAsync(long roleId);
        Task<List<Role>> GetRolesListAsync();
    }
}
