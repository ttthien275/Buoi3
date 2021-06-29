using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Buoi3.Models
{
    public partial class Book : DbContext
    {
        public Book()
            : base("name=Book")
        {
        }

        public virtual DbSet<SACH> SACHes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SACH>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SACH>()
                .Property(e => e.Images)
                .IsUnicode(false);
        }
    }
}
