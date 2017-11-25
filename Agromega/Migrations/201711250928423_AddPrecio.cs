namespace Agromega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrecio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Precio_Actual", "Precio", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Precio_Actual", "Precio");
        }
    }
}
