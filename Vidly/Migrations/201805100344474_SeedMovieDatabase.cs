namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMovieDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Title, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Howls Moving Castle', '01/01/2000', '01/01/2000', 4, 4)");
            Sql("INSERT INTO Movies (Title, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Die Hard', '01/01/2000', '01/01/2000', 5, 2)");
            Sql("INSERT INTO Movies (Title, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Shrek!', '01/01/2000', '01/01/2000', 6, 2)");
            Sql("INSERT INTO Movies (Title, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Gladiator', '01/01/2000', '01/01/2000', 3, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
