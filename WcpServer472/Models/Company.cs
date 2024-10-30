using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcpServer472.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public string Address { get; set; }
        [Required, MaxLength(8)]
        public int INN { get; set; }
        public int? Telephone { get; set; }
        public string Email { get; set; }
        public List<User> Employees { get; set; }
    }
}
