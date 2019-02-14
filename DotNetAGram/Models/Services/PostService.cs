using DotNetAGram.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAGram.Models.Services
{
    public class PostService : IPost
    {
        private DotNetAGramDbContext _table { get; }

        public PostService(DotNetAGramDbContext post)
        {
            _table = post;
        }

        public Task CreatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPost(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetPosts()
        {
            throw new NotImplementedException();
        }
    }
}
