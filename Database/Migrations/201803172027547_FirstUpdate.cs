namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UdhyogTypes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UdhyogTypes", "Name", c => c.String());
        }
    }
}
