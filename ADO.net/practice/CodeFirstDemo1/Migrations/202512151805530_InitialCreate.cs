namespace CodeFirstDemo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IPLs",
                c => new
                    {
                        TeamID = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        Captain = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.TeamID);
            
            CreateTable(
                "dbo.Studentstbl",
                c => new
                    {
                        Sid = c.Int(nullable: false),
                        studentfullname = c.String(nullable: false, maxLength: 20, unicode: false),
                        DOB = c.DateTime(nullable: false),
                        Class = c.Int(nullable: false),
                        Emailaddress = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Sid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Studentstbl");
            DropTable("dbo.IPLs");
        }
    }
}
