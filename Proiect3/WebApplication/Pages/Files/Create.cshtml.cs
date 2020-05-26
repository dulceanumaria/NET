using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference;

namespace WebApplication.Pages.Files
{
    public class CreateModel : PageModel
    {
        InterfaceWCFClient pcc = new InterfaceWCFClient();

        [BindProperty]
        public FilesDTO FilesDTO { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            FilesDTO file = new FilesDTO();
            file.cale = FilesDTO.cale;
            file.nume_fisier = FilesDTO.nume_fisier;
            file.data_creare = FilesDTO.data_creare;
            file.locatie = FilesDTO.locatie;
            file.eveniment = FilesDTO.eveniment;
            file.peisaj = FilesDTO.peisaj;
            file.descriere = FilesDTO.descriere;
            await pcc.AddFileAsync(file.nume_fisier, file.cale, file.data_creare, file.locatie, file.eveniment, file.peisaj, file.descriere);
            
            return RedirectToPage("./Index");
        }
    }
}
