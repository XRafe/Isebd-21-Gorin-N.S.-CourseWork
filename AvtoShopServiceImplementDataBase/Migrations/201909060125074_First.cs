namespace AvtoShopServiceImplementDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firm = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PassportData = c.String(),
                        FIO = c.String(),
                        NumberPhone = c.String(),
                        Bonus = c.Int(nullable: false),
                        BlockStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Sum = c.Int(nullable: false),
                        DateCreate = c.DateTime(nullable: false),
                        ClientFIO = c.String(),
                        Car_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.Car_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Paid = c.Int(nullable: false),
                        DatePay = c.String(),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Orders", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.Cars", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Orders", new[] { "Car_Id" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropIndex("dbo.Cars", new[] { "Client_Id" });
            DropTable("dbo.Payments");
            DropTable("dbo.Orders");
            DropTable("dbo.Clients");
            DropTable("dbo.Cars");
        }
    }
}
