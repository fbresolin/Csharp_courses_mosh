namespace VidzyCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVideoGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VideoGenres (Video_Id, Genre_Id) VALUES (1,3)");
            Sql("INSERT INTO VideoGenres (Video_Id, Genre_Id) VALUES (1,2)");
            Sql("INSERT INTO VideoGenres (Video_Id, Genre_Id) VALUES (2,1)");
            Sql("INSERT INTO VideoGenres (Video_Id, Genre_Id) VALUES (3,2)");
        }
        
        public override void Down()
        {
        }
    }
}
