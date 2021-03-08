using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trial.Blog.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "trial_categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, comment: "The id of category"),
                    CategoryName = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false, comment: "The category name of blog"),
                    DisplayName = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false, comment: "The display name of category"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trial_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "trial_friend_links",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, comment: "The id of friend link"),
                    Title = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false, comment: "The title of friend link"),
                    LinkUrl = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: false, comment: "The link url of friend link"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trial_friend_links", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "trial_post_tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, comment: "The id of post tag"),
                    PostId = table.Column<int>(type: "int", nullable: false, comment: "the post id of blog"),
                    TagId = table.Column<int>(type: "int", nullable: false, comment: "the tag id of blog"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trial_post_tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "trial_posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, comment: "The id of post record"),
                    Title = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: false, comment: "The title of blog"),
                    Author = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true, comment: "The author of blog"),
                    Url = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", maxLength: 255, nullable: false, comment: "The url of blog"),
                    Html = table.Column<string>(type: "longtext", nullable: false, comment: "The html of blog"),
                    Markdown = table.Column<string>(type: "longtext", nullable: false, comment: "The markdown of blog"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "The category id of blog"),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "the creation time"),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trial_posts", x => x.Id);
                },
                comment: "The content of blog");

            migrationBuilder.CreateTable(
                name: "trial_tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, comment: "The id of tag"),
                    TagName = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false, comment: "the tag name"),
                    DisplayName = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false, comment: "The display name of tag"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trial_tags", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "trial_categories");

            migrationBuilder.DropTable(
                name: "trial_friend_links");

            migrationBuilder.DropTable(
                name: "trial_post_tags");

            migrationBuilder.DropTable(
                name: "trial_posts");

            migrationBuilder.DropTable(
                name: "trial_tags");
        }
    }
}
