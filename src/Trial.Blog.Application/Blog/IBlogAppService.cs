using System;
using System.Threading.Tasks;

namespace Trial.Blog.Blog
{
    public interface IBlogAppService
    {
        Task<bool> InsertPostAsync(PostDto postDto);

        Task<bool> DeletePostAsync(Guid id);

        Task<bool> UpdatePostAsync(Guid id, PostDto postDto);

        Task<PostDto> GetPostAsync(Guid id);
    }
}