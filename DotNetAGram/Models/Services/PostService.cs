using DotNetAGram.Data;
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

        /// <summary>
        /// Custom constructor that facilitates dependency injection
        /// </summary>
        /// <param name="post"></param>
        public PostService(DotNetAGramDbContext post)
        {
            _table = post;
        }


        /// <summary>
        /// This method takes a post object, checks if it exists in the database, adds it to the db if it doesn't, and then saves the db
        /// </summary>
        /// <param name="post"></param>
        /// <returns>A Task object</returns>
        public async Task CreatePost(Post post)
        {
            if (await _table.Posts.FirstOrDefaultAsync(p => p.ID == post.ID) == null)
            {
                await _table.Posts.Add(post);
                await _table.SaveChangesAsync();
            }
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
