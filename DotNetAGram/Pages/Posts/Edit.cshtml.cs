using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetAGram.Pages.Posts
{
    public class EditModel : PageModel
    {
        [FromRoute]
        public int? ID { get; set; }

        public void OnGet()
        {

        }
    }
}