namespace Infinite.DogStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DogStores", newName: "Dogs");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Dogs", newName: "DogStores");
        }
    }
}
