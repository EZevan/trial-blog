using Microsoft.EntityFrameworkCore;
using Trial.Blog.Entities;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using static Trial.Blog.TrialBlogDbConst;

namespace Trial.Blog.EntityFrameworkCore
{
    public static class TrialBlogDbContextModelCreatingExtensions
    {
        public static void ConfigureBlog(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BlogConsts.DbTablePrefix + "YourEntities", BlogConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<Post>(b =>
            {
                b.ToTable(TrialBlogConsts.DbTablePrefix + DbTableName.Posts).HasComment("The content of blog.");
                b.ConfigureByConvention();
                b.HasKey(x => x.Id);
                b.Property(x => x.Id).HasComment("The id of post record");
                b.Property(x => x.Title).HasMaxLength(255).IsRequired().HasComment("The title of blog");
                b.Property(x => x.Author).HasMaxLength(50).HasComment("The author of blog");
                b.Property(x => x.Url).HasMaxLength(255).IsRequired().HasComment("The url of blog");
                b.Property(x => x.Html).HasColumnType("longtext").IsRequired().HasComment("The html of blog");
                b.Property(x => x.Markdown).HasColumnType("longtext").IsRequired().HasComment("The markdown of blog");
                b.Property(x => x.CategoryId).HasColumnType("int").HasComment("The category id of blog");
                b.Property(x => x.CreationTime).HasColumnType("datetime").HasComment("the creation time");
            });

            builder.Entity<Category>(b =>
            {
                b.ToTable(TrialBlogConsts.DbTablePrefix + DbTableName.Categories).HasComment("The category of blog.");
                b.ConfigureByConvention();
                b.HasKey(x => x.Id);
                b.Property(x => x.Id).HasComment("The id of category");
                b.Property(x => x.CategoryName).HasMaxLength(50).IsRequired().HasComment("The category name of blog");
                b.Property(x => x.DisplayName).HasMaxLength(50).IsRequired().HasComment("The display name of category");
            });

            builder.Entity<Tag>(b =>
            {
                b.ToTable(TrialBlogConsts.DbTablePrefix + DbTableName.Tags).HasComment("The tag of blog.");
                b.ConfigureByConvention();
                b.HasKey(x => x.Id);
                b.Property(x => x.Id).HasComment("The id of tag");
                b.Property(x => x.TagName).HasMaxLength(50).IsRequired().HasComment("the tag name");
                b.Property(x => x.DisplayName).HasMaxLength(50).IsRequired().HasComment("The display name of tag");
            });

            builder.Entity<PostTag>(b =>
            {
                b.ToTable(TrialBlogConsts.DbTablePrefix + DbTableName.PostTags).HasComment("The post tab of blog.");
                b.ConfigureByConvention();
                b.HasKey(x => x.Id);
                b.Property(x => x.Id).HasComment("The id of post tag");
                b.Property(x => x.PostId).HasColumnType("int").IsRequired().HasComment("the post id of blog");
                b.Property(x => x.TagId).HasColumnType("int").IsRequired().HasComment("the tag id of blog");
            });

            builder.Entity<FriendLink>(b =>
            {
                b.ToTable(TrialBlogConsts.DbTablePrefix + DbTableName.FriendLinks).HasComment("The friend link of blog.");
                b.ConfigureByConvention();
                b.HasKey(x => x.Id);
                b.Property(x => x.Id).HasComment("The id of friend link");
                b.Property(x => x.Title).HasMaxLength(50).IsRequired().HasComment("The title of friend link");
                b.Property(x => x.LinkUrl).HasMaxLength(255).IsRequired().HasComment("The link url of friend link");
            });
        }
    }
}