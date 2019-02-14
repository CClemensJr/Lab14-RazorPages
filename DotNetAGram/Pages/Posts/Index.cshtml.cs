using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetAGram.Models;
using DotNetAGram.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetAGram.Pages.Posts
{
    public class IndexModel : PageModel
    {
        [FromRoute]
        public int ID { get; set; }
        public Post Post { get; set; }

        private readonly IPost _post;

        /// <summary>
        /// This constructor allows the IPost interface to be accessed in the Posts Index Controller
        /// </summary>
        /// <param name="post"></param>
        public IndexModel(IPost post)
        {
            _post = post;
        }

        public async Task OnGet()
        {
            Post = await _post.GetPost(ID);
        }
    }
}