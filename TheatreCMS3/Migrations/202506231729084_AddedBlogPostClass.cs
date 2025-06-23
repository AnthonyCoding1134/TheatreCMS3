namespace TheatreCMS3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBlogPostClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogPosts",
                c => new
                    {
                        BlogPostId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Content = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        BlogAuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BlogPostId)
                .ForeignKey("dbo.BlogAuthors", t => t.BlogAuthorId, cascadeDelete: true)
                .Index(t => t.BlogAuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogPosts", "BlogAuthorId", "dbo.BlogAuthors");
            DropIndex("dbo.BlogPosts", new[] { "BlogAuthorId" });
            DropTable("dbo.BlogPosts");
        }
    }
}
