﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.Blog.Entities;
using Volo.Abp.Domain.Repositories;

namespace Trial.Blog.BlogEntities.Repositories
{
    /// <summary>
    /// IPostRepository
    /// </summary>
    public interface IPostRepository : IRepository<Post,Guid>
    {
    }
}
