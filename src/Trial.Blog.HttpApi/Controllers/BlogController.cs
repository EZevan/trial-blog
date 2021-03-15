using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trial.Blog.Application.HelloAbp;
using Trial.Blog.Blog;
using Volo.Abp.AspNetCore.Mvc;

namespace Trial.Blog.Controllers
{
    [ApiController]
    [Route("blog")]
    public class BlogController : AbpController
    {
        private readonly IBlogAppService _blogService;
        
        public BlogController(IBlogAppService blogService)
        {
            _blogService = blogService;
        }

        /// <summary>
        /// Add new blog.
        /// </summary>
        /// <param name="postDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<bool> AddPostAsync([FromBody] PostDto postDto)
        {
            return await _blogService.InsertPostAsync(postDto);
        }
        
        /// <summary>
        /// Remove post with specified post id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<bool> DeletePostAsync([Required] Guid id)
        {
            return await _blogService.DeletePostAsync(id);
        }

        /// <summary>
        /// Update post with specified post id。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="postDto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<bool> UpdatePostAsync([Required] Guid id, [FromBody] PostDto postDto)
        {
            return await _blogService.UpdatePostAsync(id, postDto);
        }
    
        /// <summary>
        /// Get post with specified post id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<PostDto> GetPostAsync([Required] Guid id)
        {
            return await _blogService.GetPostAsync(id);
        }
    }
}