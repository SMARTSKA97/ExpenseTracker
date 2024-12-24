using System.Collections.Generic;
using System.Threading.Tasks;
using ExpenseTracker.Core.Entities;

namespace ExpenseTracker.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int id);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task AddUserAsync(User user);
    }
}