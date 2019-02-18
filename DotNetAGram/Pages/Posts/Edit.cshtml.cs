using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DotNetAGram.Models;
using DotNetAGram.Models.Interfaces;

namespace DotNetAGram.Pages.Posts
{
    public class EditModel : PageModel
    {
        private readonly IPost _post;

        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public Post Post { get; set; }

        /// <summary>
        /// This constructor allows the IPost interface to be accessed in the Posts Index Controller
        /// </summary>
        /// <param name="post"></param>
        public EditModel(IPost post)
        {
            _post = post;
        }

        /// <summary>
        /// This method sends the object to the page with the same ID
        /// </summary>
        /// <returns>A Task object</returns>
        public async Task OnGet()
        {
            Post = await _post.GetPost(ID.GetValueOrDefault());
        }

        /// <summary>
        /// This method updates the post upon form submission then redirects to the index page
        /// </summary>
        /// <returns>A redirect to the index page</returns>
        public async Task<IActionResult> OnPost()
        {
            var post = await _post.GetPost(ID.GetValueOrDefault());

            post.Description = Post.Description;

            await _post.EditPost(post);

            return RedirectToPage("/Index");
        }

    }
}