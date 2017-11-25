namespace Agromega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCultivo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cultivo",
                c => new
                    {
                        CultivoId = c.Int(nullable: false, identity: true),
                        NombreCultivo = c.String(),
                    })
                .PrimaryKey(t => t.CultivoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cultivo");
        }
    }
}
