using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Model;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string ApiHost { get; }

        public IndexModel(ILogger<IndexModel> logger, ApiConfig config)
        {
            ApiHost = config.ApiHost;
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
