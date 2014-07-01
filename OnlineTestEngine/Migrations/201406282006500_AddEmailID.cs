namespace OnlineTestEngine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Email");
        }
    }
}
