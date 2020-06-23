namespace BlogNew1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artykulies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tytul = c.String(),
                        Wstep = c.String(),
                        TekstArtykulu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Artykulies");
        }
    }
}
