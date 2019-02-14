using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAGram.Models.Interfaces
{
    public interface IPost
    {
        // Create
        Task CreatePost(Post post);

        // Read
        Task<Post>GetPost(int id);

        // ReadAll
        Task<IEnumerable<Post>> GetPosts();

        // Update
        Task EditPost(int id);

        // Destroy
        Task DeletePost(int id);
    }
}
