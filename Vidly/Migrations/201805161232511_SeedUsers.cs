namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'932dd5da-84c3-4ea0-b343-a26d4a18564f', N'guest@vidly.com', 0, N'ACpJiOtVqzgtH1e+bjkdiK6qhdaZedDvaLKx0cs8AHJAu7hyeqGnwXYAO4PEsopXug==', N'b30ce518-595a-4009-abb5-2a9997973554', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e9b97005-fddd-4719-a8cf-b251677cf850', N'manager@vidly.com', 0, N'AD0Wo5Uls2ytIUENg2l+0MwJEbpZh4a/MhoTJd7igzVW0evSLCM34RMR5UtsA1p4wQ==', N'6755abb9-fd1d-4f54-b7e7-21a38d7a3d50', NULL, 0, 0, NULL, 1, 0, N'manager@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'624c085d-9367-4121-ae22-1f7a717eef01', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e9b97005-fddd-4719-a8cf-b251677cf850', N'624c085d-9367-4121-ae22-1f7a717eef01')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
