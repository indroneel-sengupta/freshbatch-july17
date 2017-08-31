namespace CodeToDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Did = c.Int(nullable: false, identity: true),
                        DName = c.String(),
                        DAdress = c.String(),
                    })
                .PrimaryKey(t => t.Did);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departments");
        }
    }
}
