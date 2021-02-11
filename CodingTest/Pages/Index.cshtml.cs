using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CodingTest.Core;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingTest.Pages
{
    public class IndexModel : PageModel
    {


        private readonly ILogger<IndexModel> _logger;

        


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
           
        }

        public void OnGet()
        {
            
        }
    }
}
