namespace BeleZandoWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableAtendente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBATNDBLZ",
                c => new
                    {
                        ATCODBLZ = c.Int(nullable: false, identity: true),
                        ATNMBLZ = c.String(nullable: false, maxLength: 250),
                        ATEMLBLZ = c.String(nullable: false, maxLength: 250),
                        ATTLFBLZ = c.String(nullable: false, maxLength: 14),
                        ATSNHBLZ = c.String(nullable: false, maxLength: 32),
                        ATSITBLZ = c.String(nullable: false, maxLength: 250),
                        ATULTABLZ = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ATCODBLZ);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TBATNDBLZ");
        }
    }
}
