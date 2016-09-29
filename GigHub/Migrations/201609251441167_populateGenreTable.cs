namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenreTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Author_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Gigs", new[] { "Author_Id" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Gigs", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Gigs", "Author_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Gigs", "Author_Id");
            AddForeignKey("dbo.Gigs", "Author_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            Sql("INSERT INTO Genres (Id, Name) VALUES(1, 'JAZZ')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(2, 'ROCK')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(3, 'POP')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(4, 'CLASSIC')");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "Author_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Gigs", new[] { "Author_Id" });
            AlterColumn("dbo.Gigs", "Author_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Gigs", "Venue", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            CreateIndex("dbo.Gigs", "Author_Id");
            AddForeignKey("dbo.Gigs", "Author_Id", "dbo.AspNetUsers", "Id");
            Sql("DELETE FROM GENRES WHERE ID IN (1,2,3,4)");
        }
    }
}
