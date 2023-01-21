namespace Infinite.DogStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DogBreeds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DogBreedName = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DogStores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DogName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false),
                        Height = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        DogBreedId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DogBreeds", t => t.DogBreedId, cascadeDelete: true)
                .Index(t => t.DogBreedId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DogStores", "DogBreedId", "dbo.DogBreeds");
            DropIndex("dbo.DogStores", new[] { "DogBreedId" });
            DropTable("dbo.DogStores");
            DropTable("dbo.DogBreeds");
        }
    }
}
