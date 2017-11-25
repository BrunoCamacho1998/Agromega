namespace Agromega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCultivox : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produccion", "CultivoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Produccion", "CultivoId");
            AddForeignKey("dbo.Produccion", "CultivoId", "dbo.Cultivo", "CultivoId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produccion", "CultivoId", "dbo.Cultivo");
            DropIndex("dbo.Produccion", new[] { "CultivoId" });
            DropColumn("dbo.Produccion", "CultivoId");
        }
    }
}
