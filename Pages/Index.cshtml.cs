using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace lc2.Pages
{

    public class IndexModel : PageModel
    {
            [BindProperty(SupportsGet = true)]
            public QuickType.Sampledata Results {get;private set;}

            private IHttpClientFactory _httpClientFactory;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult OnGet()
        {
            var data = Task.Run(async () => await GetSampledata()).Result;

            if(data!=null){
                _logger.LogInformation("Data is present");
                Results = data;
            }

            return Page();
        }

        private async Task<QuickType.Sampledata> GetSampledata()
        {
            var client = _httpClientFactory.CreateClient("API Client");
            var result = await client.GetAsync("/api/v2.0/results?game=59bc2b6031947b9daf338d32");
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals
                };
                options.Converters.Add(new QuickType.StringConverter());
                var o = JsonSerializer.Deserialize<QuickType.Sampledata[]>(content, options);
                var data = o[1];
                
                return data;
            }
            return null;
        }
    }
}
