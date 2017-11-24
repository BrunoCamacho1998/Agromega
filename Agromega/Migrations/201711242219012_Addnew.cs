namespace Agromega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addnew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoClima",
                c => new
                    {
                        TipoClimaId = c.Int(nullable: false, identity: true),
                        NombreClima = c.String(),
                    })
                .PrimaryKey(t => t.TipoClimaId);
            
            CreateTable(
                "dbo.TipoSuelo",
                c => new
                    {
                        TipoSueloId = c.Int(nullable: false, identity: true),
                        NombreTipoSuelo = c.String(),
                    })
                .PrimaryKey(t => t.TipoSueloId);
            
            AddColumn("dbo.Produccion", "TipoClimaId", c => c.Int(nullable: false));
            AddColumn("dbo.Produccion", "TipoSueloId", c => c.Int(nullable: false));
            CreateIndex("dbo.Produccion", "TipoClimaId");
            CreateIndex("dbo.Produccion", "TipoSueloId");
            AddForeignKey("dbo.Produccion", "TipoClimaId", "dbo.TipoClima", "TipoClimaId", cascadeDelete: true);
            AddForeignKey("dbo.Produccion", "TipoSueloId", "dbo.TipoSuelo", "TipoSueloId", cascadeDelete: true);
            DropColumn("dbo.Produccion", "Clima");
            DropColumn("dbo.Produccion", "TipoSuelo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produccion", "TipoSuelo", c => c.String());
            AddColumn("dbo.Produccion", "Clima", c => c.String());
            DropForeignKey("dbo.Produccion", "TipoSueloId", "dbo.TipoSuelo");
            DropForeignKey("dbo.Produccion", "TipoClimaId", "dbo.TipoClima");
            DropIndex("dbo.Produccion", new[] { "TipoSueloId" });
            DropIndex("dbo.Produccion", new[] { "TipoClimaId" });
            DropColumn("dbo.Produccion", "TipoSueloId");
            DropColumn("dbo.Produccion", "TipoClimaId");
            DropTable("dbo.TipoSuelo");
            DropTable("dbo.TipoClima");
        }
    }
}
