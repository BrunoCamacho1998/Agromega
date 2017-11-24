namespace Agromega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProduccion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produccion", "TipoSuelo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produccion", "TipoSuelo");
        }
    }
}
