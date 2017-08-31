namespace CodeToDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartment : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Departments", name: "DName", newName: "DEPTNAMENEW");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Departments", name: "DEPTNAMENEW", newName: "DName");
        }
    }
}
