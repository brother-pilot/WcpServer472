using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WcpServer472.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace WcpServer472.DAL
{
    public class RepositoryContext : DbContext
    {
        

        public DbSet<Company> Companys => Set<Company>();
        public DbSet<User> Users => Set<User>();

        public RepositoryContext()
        {
            if (Database.Exists())
            {
                Database.CreateIfNotExists();
                //когда используем миграции то это должно быть отключено
                Console.WriteLine("База данных не существовала, поэтому она была создана");
            }
        }

        //public RepositoryContext(string connString)
        //    : base(connString)
        //{

        //}


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //привязка свойства Id и поля id!!!!!
            //modelBuilder.Entity<CurrentUser>().Property("Name").HasField("name");
            //modelBuilder.Entity<CurrentUser>().Property("Level").HasField("level");
            //modelBuilder.Entity<InfoWork>().Property("Data").HasField("data");
            //modelBuilder.Entity<InfoWork>().Property("Name").HasField("name");
            //modelBuilder.Entity<InfoWork>().Property("Time").HasField("time");
            //modelBuilder.Entity<InfoWork>().Property("Work").HasField("work");
        }



    }
}
