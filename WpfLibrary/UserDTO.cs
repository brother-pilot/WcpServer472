using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfContract
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Telephone { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Photo { get; set; }

    }
}
