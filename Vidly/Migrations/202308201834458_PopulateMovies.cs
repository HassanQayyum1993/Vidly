namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres (Id, Name) Values(1, 'Action')");
            Sql("INSERT INTO MovieGenres (Id, Name) Values(2, 'Thriller')");
            Sql("INSERT INTO MovieGenres (Id, Name) Values(3, 'Family')");
            Sql("INSERT INTO MovieGenres (Id, Name) Values(4, 'Romance')");
            Sql("INSERT INTO MovieGenres (Id, Name) Values(5, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
