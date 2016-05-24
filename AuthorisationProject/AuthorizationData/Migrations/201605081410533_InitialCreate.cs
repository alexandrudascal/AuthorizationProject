namespace AuthorizationData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActivityProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Activity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Authorizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ASVF = c.String(),
                        EliberationDate = c.DateTime(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                        AuthorizatedObjectName = c.String(),
                        AuthorizatedObjectPhone = c.String(),
                        AuthorizatedObjectAddress = c.String(),
                        SubdivisionId = c.Int(nullable: false),
                        AgentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agents", t => t.AgentId, cascadeDelete: true)
                .ForeignKey("dbo.Subdivisions", t => t.SubdivisionId, cascadeDelete: true)
                .Index(t => t.SubdivisionId)
                .Index(t => t.AgentId);
            
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subdivisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        LeaderFirstName = c.String(),
                        LeaderLastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AuthorizationActivityProfiles",
                c => new
                    {
                        Authorization_Id = c.Int(nullable: false),
                        ActivityProfile_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Authorization_Id, t.ActivityProfile_Id })
                .ForeignKey("dbo.Authorizations", t => t.Authorization_Id, cascadeDelete: true)
                .ForeignKey("dbo.ActivityProfiles", t => t.ActivityProfile_Id, cascadeDelete: true)
                .Index(t => t.Authorization_Id)
                .Index(t => t.ActivityProfile_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Authorizations", "SubdivisionId", "dbo.Subdivisions");
            DropForeignKey("dbo.Authorizations", "AgentId", "dbo.Agents");
            DropForeignKey("dbo.AuthorizationActivityProfiles", "ActivityProfile_Id", "dbo.ActivityProfiles");
            DropForeignKey("dbo.AuthorizationActivityProfiles", "Authorization_Id", "dbo.Authorizations");
            DropIndex("dbo.AuthorizationActivityProfiles", new[] { "ActivityProfile_Id" });
            DropIndex("dbo.AuthorizationActivityProfiles", new[] { "Authorization_Id" });
            DropIndex("dbo.Authorizations", new[] { "AgentId" });
            DropIndex("dbo.Authorizations", new[] { "SubdivisionId" });
            DropTable("dbo.AuthorizationActivityProfiles");
            DropTable("dbo.Subdivisions");
            DropTable("dbo.Agents");
            DropTable("dbo.Authorizations");
            DropTable("dbo.ActivityProfiles");
        }
    }
}
