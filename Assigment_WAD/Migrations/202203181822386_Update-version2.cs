namespace Assigment_WAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updateversion2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Prices", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Prices");
        }
    }
}
