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
    /// IFriendLinkRepository
    /// </summary>
    public interface IFriendLinkRepository : IRepository<FriendLink,Guid>
    {
    }
}
