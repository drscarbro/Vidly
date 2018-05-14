namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipAndGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MEMBERSHIPTYPES (Id, Name, SignUpFee, Duration, DiscountRate) VALUES (1, 'Pay as You Go', 0, 0, 0)");
            Sql("INSERT INTO MEMBERSHIPTYPES (Id, Name, SignUpFee, Duration, DiscountRate) VALUES (2, 'Monthly', 10, 1, 10)");
            Sql("INSERT INTO MEMBERSHIPTYPES (Id, Name, SignUpFee, Duration, DiscountRate) VALUES (3, 'Three Month', 30, 3, 15)");
            Sql("INSERT INTO MEMBERSHIPTYPES (Id, Name, SignUpFee, Duration, DiscountRate) VALUES (4, '12 Month', 120, 12, 20)");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (2, 'Drama')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (3, 'Thriller')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (4, 'Action')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (5, 'Anime')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (6, 'Fantasy')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (7, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
