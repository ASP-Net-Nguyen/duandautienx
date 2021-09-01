using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace duandautienx.Pages
{
    public class UrlBingDingModel : PageModel
    {
/*        [BindProperty (SupportsGet = true)]
        public int age { get; set; }*/
        public string Message { get; set; }
        public void OnGet(string fullname, string email, int age) => Message = age < 18 ?
            $"Sorry" :
            $"Hello";
    }
}
