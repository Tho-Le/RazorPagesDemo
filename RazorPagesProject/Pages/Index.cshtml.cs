using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Models;
using Services;

namespace RazorPagesProject.Pages
{
    public class IndexModel : PageModel
    {


        public string Message { get; set; }
    
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        }

        public void OnGet()
        {
            Message = $"Hello World! The time is now {DateTime.Now.ToLongTimeString()}";
        }
    }
}
