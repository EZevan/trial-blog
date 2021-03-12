using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.Blog.Entities;
using Volo.Abp.Domain.Repositories;

namespace Trial.Blog.BlogEntities.Repositories
{
    /// <summary>
    /// ITagRepository
    /// </summary>
    public interface ITagRepository : IRepository<Tag,Guid>
    {
        /// <summary>
        /// Bulk Insertion <see cref="Tag"/>.
        /// </summary>
        /// <param name="tags">A collection object of <see cref="Tag"/>.</param>
        /// <returns>The <see cref="Task"/> object.</returns>
        Task BulkInsertAsync(IEnumerable<Tag> tags);
    }
}
