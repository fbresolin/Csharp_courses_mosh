namespace VidzyCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Romance')");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Name='Action'");
            Sql("DELETE FROM Genres WHERE Name='Drama'");
            Sql("DELETE FROM Genres WHERE Name='Romance'");
            
        }
    }
}
