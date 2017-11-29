namespace Astra.ToDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        IsDone = c.Boolean(nullable: false),
                        _CreatedUtc = c.DateTime(nullable: false),
                        _CreatedBy = c.String(),
                        _CreatedAgent = c.String(),
                        _LastModifiedUtc = c.DateTime(nullable: false),
                        _LastModifiedBy = c.String(),
                        _LastModifiedAgent = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToDoItems");
        }
    }
}
