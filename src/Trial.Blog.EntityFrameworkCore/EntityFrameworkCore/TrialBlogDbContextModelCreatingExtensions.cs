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
                b.ToTable(TrialBlogConsts.DbTablePrefix + DbTableName.Posts);
                b.ConfigureByConvention();
                b.HasKey(x => x.Id);
                b.Property(x => x.Title).HasMaxLength(255).IsRequired();
                b.Property(x => x.Author).HasMaxLength(50);
                b.Property(x => x.Url).HasMaxLength(255).IsRequired();
                b.Property(x => x.Html).HasColumnType("longtext").IsRequired();
                b.Property(x => x.Markdown).HasColumnType("longtext").IsRequired();
                b.Property(x => x.CategoryId).HasColumnType("int");
                b.Property(x => x.CreationTime).HasColumnType("datetime");
            });

            builder.Entity<Category>(b =>
            {
                b.ToTable(TrialBlogConsts.DbTablePrefix + DbTableName.Categories);
                b.ConfigureByConvention();
                b.HasKey(x => x.Id);
                b.Property(x => x.CategoryName).HasMaxLength(50).IsRequired();
                b.Property(x => x.DisplayName).HasMaxLength(50).IsRequired();
            });

            builder.Entity<Tag>(b =>
            {
                b.ToTable(TrialBlogConsts.DbTablePrefix + DbTableName.Tags);
                b.ConfigureByConvention();
                b.HasKey(x => x.Id);
                b.Property(x => x.TagName).HasMaxLength(50).IsRequired();
                b.Property(x => x.DisplayName).HasMaxLength(50).IsRequired();
            });

            builder.Entity<PostTag>(b =>
            {
                b.ToTable(TrialBlogConsts.DbTablePrefix + DbTableName.PostTags);
                b.ConfigureByConvention();
                b.HasKey(x => x.Id);
                b.Property(x => x.PostId).HasColumnType("int").IsRequired();
                b.Property(x => x.TagId).HasColumnType("int").IsRequired();
            });

            builder.Entity<FriendLink>(b =>
            {
                b.ToTable(TrialBlogConsts.DbTablePrefix + DbTableName.FriendLinks);
                b.ConfigureByConvention();
                b.HasKey(x => x.Id);
                b.Property(x => x.Title).HasMaxLength(50).IsRequired();
                b.Property(x => x.LinkUrl).HasMaxLength(255).IsRequired();
            });
        }
    }
}