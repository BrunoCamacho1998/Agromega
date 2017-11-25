namespace Agromega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produccion", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produccion", "Link");
        }
    }
}
