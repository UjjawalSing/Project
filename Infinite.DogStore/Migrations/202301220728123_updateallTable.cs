namespace Infinite.DogStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateallTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRolesMappings", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserRolesMappings", "UserId", "dbo.Users");
            DropIndex("dbo.UserRolesMappings", new[] { "UserId" });
            DropIndex("dbo.UserRolesMappings", new[] { "RoleId" });
            DropTable("dbo.Roles");
            DropTable("dbo.UserRolesMappings");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmailId = c.String(nullable: false, maxLength: 50),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRolesMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.UserRolesMappings", "RoleId");
            CreateIndex("dbo.UserRolesMappings", "UserId");
            AddForeignKey("dbo.UserRolesMappings", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRolesMappings", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
        }
    }
}
