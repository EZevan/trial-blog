﻿using System;
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
    /// <summary>
    /// PostRepository
    /// </summary>
    public class PostRepository : EfCoreRepository<TrialBlogDbContext,Post,Guid>, IPostRepository
    {
        public PostRepository(IDbContextProvider<TrialBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
