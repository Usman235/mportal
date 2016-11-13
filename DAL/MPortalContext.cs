using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Configuration;
using DAL.Entity;

namespace DAL
{
   public class MPortalContext:DbContext
    {
        public MPortalContext() : base("MPortal")
        {
            Database.SetInitializer<MPortalContext>(null);
        }
        #region Entity Sets
        public IDbSet<Customer> CustomerSet { get; set; }
        public IDbSet<Order> OrderSet { get; set; }
       //ublic IDbSet<Role> RoleSet { get; set; }
       //ublic IDbSet<UserRole> UserRoleSet { get; set; }
       //ublic IDbSet<Customer> CustomerSet { get; set; }
       //ublic IDbSet<Movie> MovieSet { get; set; }
       //ublic IDbSet<Genre> GenreSet { get; set; }
       //ublic IDbSet<Stock> StockSet { get; set; }
       //ublic IDbSet<Rental> RentalSet { get; set; }
        //public IDbSet<Error> ErrorSet { get; set; }
        #endregion
        public virtual void Commit()
        {
            base.SaveChanges();

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            //modelBuilder.Configurations.Add(new UserRoleConfiguration());
            //modelBuilder.Configurations.Add(new RoleConfiguration());
            //modelBuilder.Configurations.Add(new CustomerConfiguration());
            //modelBuilder.Configurations.Add(new MovieConfiguration());
            //modelBuilder.Configurations.Add(new GenreConfiguration());
            //modelBuilder.Configurations.Add(new StockConfiguration());
            //modelBuilder.Configurations.Add(new RentalConfiguration());
        }



    }
}
