namespace NetBeeTicket.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        Password = c.String(nullable: false, maxLength: 50, unicode: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PaymentRate = c.String(),
                        PaymentMethod = c.String(),
                        SubscriptionType = c.String(),
                        SubscriptionAmount = c.Double(),
                        SubscriptionStartDate = c.DateTime(nullable: false),
                        SubscriptionDetails = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        RoleCode = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "RoleId", "dbo.Role");
            DropIndex("dbo.Customer", new[] { "RoleId" });
            DropTable("dbo.Role");
            DropTable("dbo.Customer");
        }
    }
}
