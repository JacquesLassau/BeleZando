namespace BeleZandoWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBCLTBLZ",
                c => new
                    {
                        CLCODBLZ = c.Int(nullable: false, identity: true),
                        CLNMBLZ = c.String(nullable: false, maxLength: 250),
                        CLEMLBLZ = c.String(nullable: false, maxLength: 250),
                        CLCPFBLZ = c.String(nullable: false, maxLength: 14),
                        CLDTNSCBLZ = c.DateTime(nullable: false),
                        CLTLFBLZ = c.String(nullable: false, maxLength: 14),
                        CLSNHBLZ = c.String(nullable: false, maxLength: 32),
                        CLSITBLZ = c.String(nullable: false, maxLength: 250),
                        CLULTABLZ = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CLCODBLZ);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TBCLTBLZ");
        }
    }
}
