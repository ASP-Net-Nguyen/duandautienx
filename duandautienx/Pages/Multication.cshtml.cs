using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace duandautienx.Pages
{
    public class MulticationModel : PageModel
    {
        public string Message { get; set; } = "Default Get method";
        public void OnPostRegister () => Message = "Post register fired!";
        public void OnPostRegisterInfo() => Message = "Post Register Info fired";
        public void OnGetClear() => Message = "Get Clear fired";
        public void OnGetReset() => Message = "Get Reset fired";
    }
}
