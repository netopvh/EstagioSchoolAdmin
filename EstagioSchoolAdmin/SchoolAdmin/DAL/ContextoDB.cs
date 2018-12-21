using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.DAL
{
    class ContextoDB : DbContext
    {
        public ContextoDB() : base("name=escola")
        {
            try
            {
                Configuration.LazyLoadingEnabled = false;
                Configuration.ProxyCreationEnabled = false;
                Database.SetInitializer<DbContext>(null);
            }
            catch (Exception)
            {
                throw;
            }

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }
}
