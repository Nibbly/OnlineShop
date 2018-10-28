namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteProductFktoOrders : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "OrderID", "dbo.Orders");
            DropIndex("dbo.Products", new[] { "OrderID" });
            RenameColumn(table: "dbo.Products", name: "OrderID", newName: "Order_OrderID");
            AlterColumn("dbo.Products", "Order_OrderID", c => c.Int());
            CreateIndex("dbo.Products", "Order_OrderID");
            AddForeignKey("dbo.Products", "Order_OrderID", "dbo.Orders", "OrderID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Order_OrderID", "dbo.Orders");
            DropIndex("dbo.Products", new[] { "Order_OrderID" });
            AlterColumn("dbo.Products", "Order_OrderID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Products", name: "Order_OrderID", newName: "OrderID");
            CreateIndex("dbo.Products", "OrderID");
            AddForeignKey("dbo.Products", "OrderID", "dbo.Orders", "OrderID", cascadeDelete: true);
        }
    }
}
