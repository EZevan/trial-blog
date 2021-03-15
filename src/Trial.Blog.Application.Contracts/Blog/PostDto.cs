using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities.Auditing;

namespace Trial.Blog.Blog
{
    public class PostDto : AuditedEntityDto<Guid>
    {
        /// <summary>
        /// Post title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Post auther
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Post url
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Post html
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// Post markdown
        /// </summary>
        public string Markdown { get; set; }

        /// <summary>
        /// Post category id
        /// </summary>
        public Guid CategoryId { get; set; }
    }
}