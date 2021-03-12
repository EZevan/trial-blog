using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.Blog.Entities;
using Volo.Abp.Domain.Repositories;

namespace Trial.Blog.BlogEntities.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag,Guid>
    {
        /// <summary>
        /// Bulk insertion
        /// </summary>
        /// <param name="postTags">A collection object of <see cref="PostTag"/>.</param>
        /// <returns>The <see cref="Task"/> object.</returns>
        Task BulkInsertAsync(IEnumerable<PostTag> postTags);
    }
}
