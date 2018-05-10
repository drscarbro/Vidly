namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeId2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "MembershipType_Id");
        }

        public override void Down()
        {
        }
    }
}
