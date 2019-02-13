namespace OracleCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ADMIN.Vendors",
                c => new
                    {
                        VEND_ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        FIRSTNAME = c.String(),
                        LASTNAME = c.String(),
                        ADDRESS = c.String(),
                    })
                .PrimaryKey(t => t.VEND_ID);
            
        }
        
        public override void Down()
        {
            DropTable("ADMIN.Vendors");
        }
    }
}
