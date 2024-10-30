using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcpServer472.DI;
using WcpServer472.Models;

namespace WcpServer472.DAL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly RepositoryContext _context;

        public UsersRepository(RepositoryContext repositoryContext)
        {
            _context = repositoryContext;
        }

        public async Task<bool> CreateUserAsync(User user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return true;
                //return DbResult<Guid>.Ok(user.Id);
            }
            catch (Exception e)
            {
                throw new Exception($"User with id {user.Id} not created! {e.Message}");
            }
        }

        public Task<User> FindUser(User user)
        {
            //_context.Users.FirstOrDefaultAsync(s => s.Login == login);
            throw new NotImplementedException();
        }

        public async Task<User> GetUser(string name, string surName)=>

            await _context.Users.FirstOrDefaultAsync<User>(u => u.Surname == surName);
            
    }
}
