namespace MISA.WDT03.NTHHanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Guid(nullable: false),
                        CustomerCode = c.String(),
                        CustomerName = c.String(),
                        CompanyName = c.String(),
                        TaxCodeNumber = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        PaymentCardCode = c.String(),
                        TypeCard = c.String(),
                        MoneyDebt = c.String(),
                        Note = c.String(),
                        IsFiveFood = c.Boolean(nullable: false),
                        IsUnFollow = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
