using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.Blog.BlogEntities.Repositories;
using Trial.Blog.Entities;
using Trial.Blog.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Trial.Blog.Repositories.Blog
{
    public class PostTagRepository : EfCoreRepository<TrialBlogDbContext,PostTag,Guid>, IPostTagRepository
    {
        public PostTagRepository(IDbContextProvider<TrialBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <inheritdoc />
        public async Task BulkInsertAsync(IEnumerable<PostTag> postTags)
        {
            await GetDbContextAsync()
                .Result
                .AddRangeAsync(postTags);

            await GetDbContextAsync()
                .Result
                .SaveChangesAsync();
        }
    }
}
