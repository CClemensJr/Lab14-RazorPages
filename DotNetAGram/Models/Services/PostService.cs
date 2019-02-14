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

        /// <summary>
        /// This method takes and ID, searches for a matching record in the DB, deletes it, then saves the db
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object</returns>
        public async Task DeletePost(int id)
        {
            Post post = await _table.Posts.FindAsync(id);

            if (post != null)
            {
                _table.Remove(post);

                 await _table.SaveChangesAsync();
            }
        }


        /// <summary>
        /// This method takes an id, searches for it in the database, updates the record if it exists, then saves the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An Task object</returns>
        public async Task EditPost(int id)
        {
            Post post = _table.Posts.FindAsync(id);

            if (post != null)
            {
                await _table.Posts.UpdateAsync(post);

                await _table.SaveChangesAsync();
            }
        }


        /// <summary>
        /// This method takes an id, searches for it in the database, and returns it if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object of type Post</returns>
        public async Task<Post> GetPost(int id)
        {
            Post post = await _table.Post.FindAsync(id);

            if (post != null)
            {
                return post;
            }
        }



        public Task<IEnumerable<Post>> GetPosts()
        {
            throw new NotImplementedException();
        }
    }
}
