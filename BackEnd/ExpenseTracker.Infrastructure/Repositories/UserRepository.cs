using ExpenseTracker.Core.Entities;
using ExpenseTracker.Core.Interfaces;
using ExpenseTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ExpenseTrackerDbContext _context;

        public UserRepository(ExpenseTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByIdAsync(int id)
    {
        // Simulate a database call to get a user by ID.
        // Replace this with actual data access logic, e.g., Entity Framework.
        return await Task.FromResult(new User { Id = id, Name = "John Doe" });
    }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await (_context.Users?.ToListAsync() ?? Task.FromResult(new List<User>()));
        }

        public async Task AddUserAsync(User user)
        {
            if (_context.Users != null)
            {
                await _context.Users.AddAsync(user);
            }
            else
            {
                throw new InvalidOperationException("Users DbSet is null.");
            }
            await _context.SaveChangesAsync();
        }

        // Task<User> IUserRepository.GetUserByIdAsync(int id)
        // {
        //     throw new NotImplementedException();
        // }

        // Task<IEnumerable<User>> IUserRepository.GetAllUsersAsync()
        // {
        //     throw new NotImplementedException();
        // }

        // public Task AddUserAsync(User user)
        // {
        //     throw new NotImplementedException();
        // }

        // Task<User> IUserRepository.GetUserByIdAsync(int id)
        // {
        //     throw new NotImplementedException();
        // }

        // Task<IEnumerable<User>> IUserRepository.GetAllUsersAsync()
        // {
        //     throw new NotImplementedException();
        // }

        // public Task AddUserAsync(User user)
        // {
        //     throw new NotImplementedException();
        // }

        // Task<User> IUserRepository.GetUserByIdAsync(int id)
        // {
        //     throw new NotImplementedException();
        // }

        // Task<IEnumerable<User>> IUserRepository.GetAllUsersAsync()
        // {
        //     throw new NotImplementedException();
        // }

        // public Task AddUserAsync(User user)
        // {
        //     throw new NotImplementedException();
        // }

        // Task<User> IUserRepository.GetUserByIdAsync(int id)
        // {
        //     throw new NotImplementedException();
        // }

        // Task<IEnumerable<User>> IUserRepository.GetAllUsersAsync()
        // {
        //     throw new NotImplementedException();
        // }

        // public Task AddUserAsync(User user)
        // {
        //     throw new NotImplementedException();
        // }
    }
}
