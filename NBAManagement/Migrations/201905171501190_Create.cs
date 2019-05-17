namespace NBAManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 3),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.PlayerPositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Player_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Player_Id, cascadeDelete: true)
                .Index(t => t.Player_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 30),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        Gender = c.Int(nullable: false),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ShirtNumber = c.String(nullable: false, maxLength: 10),
                        Email = c.String(maxLength: 50),
                        Country_Code = c.String(nullable: false, maxLength: 3),
                        Team_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Code, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.Country_Code)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Abbreveation = c.String(nullable: false, maxLength: 50),
                        Logo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerPositions", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Players", "Country_Code", "dbo.Countries");
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Players", new[] { "Country_Code" });
            DropIndex("dbo.PlayerPositions", new[] { "Player_Id" });
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
            DropTable("dbo.PlayerPositions");
            DropTable("dbo.Countries");
        }
    }
}
