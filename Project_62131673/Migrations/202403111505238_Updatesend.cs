namespace Project_62131673.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatesend : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Subscribe", "Subscribe_62131673_Id", c => c.Int());
            CreateIndex("dbo.tb_Subscribe", "Subscribe_62131673_Id");
            AddForeignKey("dbo.tb_Subscribe", "Subscribe_62131673_Id", "dbo.tb_Subscribe", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_Subscribe", "Subscribe_62131673_Id", "dbo.tb_Subscribe");
            DropIndex("dbo.tb_Subscribe", new[] { "Subscribe_62131673_Id" });
            DropColumn("dbo.tb_Subscribe", "Subscribe_62131673_Id");
        }
    }
}
