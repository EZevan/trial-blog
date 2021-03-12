using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class TagRepository : EfCoreRepository<TrialBlogDbContext,Tag,Guid>, ITagRepository
    {
        public TagRepository(IDbContextProvider<TrialBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
            
        }

        /// <inheritdoc />
        public async Task BulkInsertAsync(IEnumerable<Tag> tags)
        {
            await GetDbContextAsync()
                .Result
                .Set<Tag>()
                .AddRangeAsync(tags);

            await GetDbContextAsync()
                .Result
                .SaveChangesAsync();
        }
    }
}
