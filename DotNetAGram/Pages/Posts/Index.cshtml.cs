using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetAGram.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetAGram.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly IPost _post;



        public void OnGet()
        {
        }
    }
}