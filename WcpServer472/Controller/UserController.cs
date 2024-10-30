using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcpServer472.DI;
using WcpServer472.DAL.Repositories;
using WcpServer472.DAL;
using WcpServer472.Models;
using WcfContract;

namespace WcpServer472.Controller
{
    public class UserController
    {
        private IUsersRepository UsersRepository { get; }

        public UserController()
        {
            UsersRepository = new UsersRepository(new RepositoryContext());
        }

        public async Task<string> SaveUser(UserDTO user)
        {
            var existUser = UsersRepository.GetUser(user.Name,user.Surname);
            if (existUser != null)
                return "Такой пользователь существует!";
            var result = await UsersRepository.CreateUserAsync(new User()
            {
                Id = Guid.NewGuid(),
                Name = user.Name,
                Surname = user.Surname,
                Telephone = user.Telephone,
                Email = user.Email,
                Company = new List<Company>() { },
                Photo = user.Photo
            });

            return "Пользователь сохранен успешно!";
        }

        public async Task<object> GetUser(UserDTO user)
        {
            var eUser = await UsersRepository.GetUser(user.Name, user.Surname);
            if (eUser == null)
                return "Такой пользователь существует!";
            else 
            {
                return new UserDTO()
                {
                    Name = eUser.Name,
                    Surname = eUser.Surname,
                    Telephone = eUser.Telephone,
                    Email = eUser.Email,
                    Company = " ",
                    Photo = eUser.Photo
                };
            }
        }
    }
}
