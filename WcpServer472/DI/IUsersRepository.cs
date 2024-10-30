using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcpServer472.Models;

namespace WcpServer472.DI
{
    
        public interface IUsersRepository
        {
            Task<bool> CreateUserAsync(User user);
            Task<User> FindUser(User user);
            Task<User> GetUser(string name, string surName);
        }
    
}
