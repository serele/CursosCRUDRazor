using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursosCRUDRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CursosCRUDRazor.Pages.ListaCursos
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Curso Curso { get; set; }

        public void OnGet()
        {

        }
    }
}