using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data
{
    public partial class OxigenContext : DbContext
    {
        public OxigenContext()
            : base("name=OxigenContext")
        {
        }

        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.DNI)
                .IsUnicode(false);
        }
    }
}
