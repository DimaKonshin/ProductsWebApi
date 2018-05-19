namespace Domain.DataBaseContextAndEntitiesDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFProductDbContext : DbContext
    {
        public EFProductDbContext()
            : base("name=EFProductDbContext")
        {
        }

        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .Property(e => e.Price)
                .HasPrecision(16, 2);
        }
    }
}
