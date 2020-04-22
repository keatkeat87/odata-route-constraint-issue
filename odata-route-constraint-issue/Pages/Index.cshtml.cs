using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace odata_route_constraint_issue.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public bool IsAmpPage { get; set; }
        public string Langauge { get; set; }

        public void OnGet(string amp, string language)
        {
            IsAmpPage = amp == "amp";
            Langauge = language ?? "english";
        }
    }
}
