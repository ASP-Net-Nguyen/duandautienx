using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace duandautienx.Pages
{
    public class MultiformModel : PageModel
    {
        public string Message { get; set; } = "Initial Request";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Message = "Form Post";
        }
        public void OnPostDelete()
        {
            Message = "Delete Handler fired";
        }
        public void OnPostEdit(int id)
        {
            Message = "Edit Handler fired";
        }
        public void OnPostView(int id)
        {
            Message = $"View Handler fired {id}";
        }

    }
}
