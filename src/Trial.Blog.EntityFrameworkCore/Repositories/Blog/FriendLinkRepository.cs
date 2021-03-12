using System;
using Trial.Blog.Entities;
using Trial.Blog.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Trial.Blog.Repositories.Blog
{
    public class FriendLinkRepository : EfCoreRepository<TrialBlogDbContext,FriendLink,Guid>
    {
        public FriendLinkRepository(IDbContextProvider<TrialBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
