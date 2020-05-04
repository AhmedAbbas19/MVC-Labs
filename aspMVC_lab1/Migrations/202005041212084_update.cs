namespace aspMVC_lab1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee", "Name", c => c.String(nullable: false, maxLength: 22));
            AlterColumn("dbo.Employee", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Employee", "Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
