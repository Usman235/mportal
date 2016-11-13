using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Configuration
{
    public class CustomerConfiguration : EntityBaseConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            Property(u => u.Name).IsRequired().HasMaxLength(100);
            //Property(u => u.Email).IsRequired().HasMaxLength(200);
            //Property(u => u.HashedPassword).IsRequired().HasMaxLength(200);
            //Property(u => u.Salt).IsRequired().HasMaxLength(200);
            //Property(u => u.IsLocked).IsRequired();
            //Property(u => u.DateCreated);
        }
    }
    
}
