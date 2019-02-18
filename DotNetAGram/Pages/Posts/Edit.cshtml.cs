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

        public EditModel(IPost post)
        {
            _post = post;
        }

        public async Task OnGet()
        {
            Post = await _post.GetPost(ID.GetValueOrDefault()) ?? new Post();
        }

        public async Task<IActionResult> OnPost()
        {
            var post = await _post.GetPost(ID.GetValueOrDefault()) ?? new Post();

            post.Author = Post.Author;
            post.PostDate = Post.PostDate;
            post.ImageURL = Post.ImageURL;
            post.Description = Post.Description;

            await _post.EditPost(post);

            return RedirectToPage("/Posts/Index", new { id = post.ID });
        }
    }
}