using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace duandautienx.Pages
{
    public class FormbindingModel : PageModel
    {
        public string Message { get; private set; }
        public void OnPost(String fullname, string email, int age) => Message = age < 10 ?
            $"Sorry, {fullname} . You cannot" :
            $"Hello, {fullname} . Thank you ";
        public void OnGet()
        {
        }
    }
}
