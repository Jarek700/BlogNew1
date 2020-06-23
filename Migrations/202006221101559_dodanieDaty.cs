namespace BlogNew1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodanieDaty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artykulies", "DataDodania", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artykulies", "DataDodania");
        }
    }
}
