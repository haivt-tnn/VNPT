namespace Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KhachSanDbContext : DbContext
    {
        public KhachSanDbContext()
            : base("name=KhachSanDbContext")
        {
        }

        public virtual DbSet<Account> Account { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
