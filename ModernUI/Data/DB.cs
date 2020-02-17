namespace ModernUI.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
            
        }
        public DbSet<tblCategory> Categories { get; set; }
        public DbSet<tblProducts> Products { get; set; }
        public DbSet<tblUser> Users { get; set; }
        public DbSet<tblUserRole> Roles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
