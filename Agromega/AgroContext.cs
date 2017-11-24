namespace Agromega
{
    using Agromega.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class AgroContext : DbContext
    {
        public DbSet<Produccion> Produccion { get; set; }
        public DbSet<TipoClima> TipoClima { get; set; }
        public DbSet<TipoSuelo> TipoSuelo { get; set; }

        public AgroContext()
            : base("name=AgroContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions
                .Remove<PluralizingTableNameConvention>();
                
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}