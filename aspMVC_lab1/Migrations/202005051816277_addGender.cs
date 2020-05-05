namespace aspMVC_lab1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGender : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employee", "Gender", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee", "Gender", c => c.Boolean(nullable: false));
        }
    }
}
