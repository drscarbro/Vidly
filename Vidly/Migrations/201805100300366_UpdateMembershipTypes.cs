namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, Duration, DiscountRate) VALUES ('Pay as You Go', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, Duration, DiscountRate) VALUES ('Monthly', 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, Duration, DiscountRate) VALUES ('Three Month', 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Name, SignUpFee, Duration, DiscountRate) VALUES ('Yearly', 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
