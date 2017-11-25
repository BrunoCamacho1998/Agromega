namespace Agromega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLink1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Produccion", "Link");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produccion", "Link", c => c.String());
        }
    }
}
