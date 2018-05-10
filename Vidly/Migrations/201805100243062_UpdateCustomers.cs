namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name, MembershipTypeId, Birthday) VALUES ('Jerome Smith', 4, '09/23/1974')");
            Sql("INSERT INTO Customers (Name, MembershipTypeId, Birthday) VALUES ('Sandie Shells', 1, '02/26/1999')");
            Sql("INSERT INTO Customers (Name, MembershipTypeId, Birthday) VALUES ('Kelly McCormmick', 3, '11/14/2000')");
        }
        
        public override void Down()
        {
        }
    }
}
