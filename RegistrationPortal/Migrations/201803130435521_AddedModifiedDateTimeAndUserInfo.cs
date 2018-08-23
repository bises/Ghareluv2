namespace RegistrationPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedModifiedDateTimeAndUserInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "DateCreated", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.People", "UserCreated", c => c.String());
            AddColumn("dbo.People", "DateModified", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.People", "UserModified", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "UserModified");
            DropColumn("dbo.People", "DateModified");
            DropColumn("dbo.People", "UserCreated");
            DropColumn("dbo.People", "DateCreated");
        }
    }
}
