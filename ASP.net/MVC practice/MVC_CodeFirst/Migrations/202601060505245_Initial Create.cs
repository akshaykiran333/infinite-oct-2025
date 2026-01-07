namespace MVC_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductsTable",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        price = c.Single(nullable: false),
                        Sales_saleId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sales", t => t.Sales_saleId)
                .Index(t => t.Sales_saleId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        saleId = c.Int(nullable: false, identity: true),
                        SaleDate = c.DateTime(),
                        QtySold = c.Int(nullable: false),
                        SaleTotal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.saleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsTable", "Sales_saleId", "dbo.Sales");
            DropIndex("dbo.ProductsTable", new[] { "Sales_saleId" });
            DropTable("dbo.Sales");
            DropTable("dbo.ProductsTable");
        }
    }
}
