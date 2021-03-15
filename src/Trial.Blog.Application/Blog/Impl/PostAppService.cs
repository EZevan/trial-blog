using System;
using System.Threading.Tasks;
using Trial.Blog.BlogEntities.Repositories;
using Trial.Blog.Entities;

namespace Trial.Blog.Blog.Impl
{
    public class PostAppService : TrialBlogApplicationServiceBase, IBlogAppService
    {
        private readonly IPostRepository _postRepository;

        public PostAppService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        
        public async Task<bool> InsertPostAsync(PostDto postDto)
        {
            var entity = new Post
            {
                Title = postDto.Title,
                Author = postDto.Author,
                Url = postDto.Url,
                CategoryId = postDto.CategoryId,
                Html = postDto.Html,
                Markdown = postDto.Markdown
            };

            var post = await _postRepository.InsertAsync(entity);

            return post != null;
        }

        public async Task<bool> DeletePostAsync(Guid id)
        {
            await _postRepository.DeleteAsync(id);
            return true;
        }

        public async Task<bool> UpdatePostAsync(Guid id, PostDto postDto)
        {
            var post = await _postRepository.GetAsync(id);

            post.Title = postDto.Title;
            post.Author = postDto.Author;
            post.Url = postDto.Url;
            post.CategoryId = postDto.CategoryId;
            post.Html = postDto.Html;
            post.Markdown = postDto.Markdown;

            await _postRepository.UpdateAsync(post);

            return true;
        }

        public async Task<PostDto> GetPostAsync(Guid id)
        {
            var post = await _postRepository.GetAsync(id);

            return new PostDto
            {
                Title = post.Title,
                Author = post.Author,
                Url = post.Url,
                CategoryId = post.CategoryId,
                Html = post.Html,
                Markdown = post.Markdown
            };
        }
    }
}