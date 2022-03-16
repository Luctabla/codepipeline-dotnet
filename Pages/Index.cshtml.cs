using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace RazorPagesIntro.Pages
{
    public class Index2Model : PageModel
    {
        public string Message { get; private set; } = "PageModel in C#";
        public string Secret { get; private set; } = "PageModel in C#";

        public void OnGet()
        {
            string value;
            string secret;
            value = Environment.GetEnvironmentVariable("KEY_1");
            secret = Environment.GetEnvironmentVariable("SECRET1");
            Message += $" The environment variable KEY_1 is { value }";
            Secret += $" The environment secret SECRET_1 is { secret }";
        }
    }
}