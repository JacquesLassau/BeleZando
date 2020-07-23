namespace BeleZandoWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableProfissional : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TBPRFSSBLZ",
                c => new
                    {
                        PFCODBLZ = c.Int(nullable: false, identity: true),
                        PFRZSBLZ = c.String(nullable: false, maxLength: 250),
                        PFNMFTBLZ = c.String(nullable: false, maxLength: 250),
                        PFEMLBLZ = c.String(nullable: false, maxLength: 250),
                        PFCPFBLZ = c.String(nullable: false, maxLength: 14),
                        PFCNPJBLZ = c.String(maxLength: 18),
                        PFTLFBLZ = c.String(nullable: false, maxLength: 14),
                        PFNUMBLZ = c.String(maxLength: 14),
                        PFENDBLZ = c.String(nullable: false, maxLength: 250),
                        PFBAIBLZ = c.String(nullable: false, maxLength: 250),
                        PFCIDBLZ = c.String(nullable: false, maxLength: 250),
                        PFUFBLZ = c.String(nullable: false, maxLength: 2),
                        PFCEPBLZ = c.String(nullable: false, maxLength: 9),
                        PFSNHBLZ = c.String(nullable: false, maxLength: 32),
                        PFSITBLZ = c.String(nullable: false, maxLength: 250),
                        PFULTABLZ = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PFCODBLZ);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TBPRFSSBLZ");
        }
    }
}
