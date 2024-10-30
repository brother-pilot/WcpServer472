using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfContract;

namespace WcpServer472.Controller
{
    public class ModelController : ITransferObject
    {
        UserController uc;

        public ModelController()
        {
            uc = new UserController();
        }

        public async Task<object> FindUser(UserDTO user)
        {
            return await uc.GetUser(user);
        }

        public async Task<string> SentUser(UserDTO user)
        {
            return await uc.SaveUser(user);
        }

        
    }
}
