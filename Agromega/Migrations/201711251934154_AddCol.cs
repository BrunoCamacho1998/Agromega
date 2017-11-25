namespace Agromega.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Precio_Actual", "T14", c => c.Double());
            AddColumn("dbo.Precio_Actual", "T15", c => c.Double());
            AddColumn("dbo.Precio_Actual", "T16", c => c.Double());
            AddColumn("dbo.Precio_Actual", "T17", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Precio_Actual", "T17");
            DropColumn("dbo.Precio_Actual", "T16");
            DropColumn("dbo.Precio_Actual", "T15");
            DropColumn("dbo.Precio_Actual", "T14");
        }
    }
}
