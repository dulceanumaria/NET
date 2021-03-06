﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference;

namespace WebApplication.Pages.Files
{
    public class IndexModel : PageModel
    {
        InterfaceWCFClient pcc = new InterfaceWCFClient();
        public List<FilesDTO> Files { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchPeisaj { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchEveniment { get; set; }

        public IndexModel()
        {
            Files = new List<FilesDTO>();
        }
        public async Task OnGetAsync()
        {
            if (string.IsNullOrEmpty(SearchString) && string.IsNullOrEmpty(SearchPeisaj) && string.IsNullOrEmpty(SearchEveniment))
            {
                var files = await pcc.GetAllFilesAsync();
                foreach (var item in files)
                {
                    // Trebuia folosit AutoMapper. Transform Post in PostDTO
                    FilesDTO pd = new FilesDTO();
                    pd.Id = item.Id;
                    pd.nume_fisier = item.nume_fisier;
                    pd.cale = item.cale;
                    pd.data_creare = item.data_creare;
                    pd.locatie = item.locatie;
                    pd.eveniment = item.eveniment;
                    pd.peisaj = item.peisaj;
                    pd.descriere = item.descriere;
                    pd.del = item.del;
                    foreach (var cc in item.Persoanes)
                    {
                        PersoaneDTO cdto = new PersoaneDTO();
                        cdto.Id = cc.Id;
                        cdto.nume_persoana = cc.nume_persoana;
                        cdto.del = cc.del;
                        pd.Persoanes.Add(cdto);
                    }
                    foreach (var cc in item.Useris)
                    {
                        UseriDTO cdto = new UseriDTO();
                        cdto.Id = cc.Id;
                        cdto.nume_complet = cc.nume_complet;
                        cdto.mail = cc.mail;
                        cdto.parola = cc.parola;
                        cdto.del = cc.del;
                        pd.Useris.Add(cdto);
                    }

                    Files.Add(pd);
                }

            }
            else if (!string.IsNullOrEmpty(SearchString) && string.IsNullOrEmpty(SearchPeisaj) && string.IsNullOrEmpty(SearchEveniment))
            {
                var files = await pcc.GetFilesByLocatieAsync(SearchString);
                foreach (var item in files)
                {
                    // Trebuia folosit AutoMapper. Transform Post in PostDTO
                    FilesDTO pd = new FilesDTO();
                    pd.Id = item.Id;
                    pd.nume_fisier = item.nume_fisier;
                    pd.cale = item.cale;
                    pd.data_creare = item.data_creare;
                    pd.locatie = item.locatie;
                    pd.eveniment = item.eveniment;
                    pd.peisaj = item.peisaj;
                    pd.descriere = item.descriere;
                    pd.del = item.del;
                    foreach (var cc in item.Persoanes)
                    {
                        PersoaneDTO cdto = new PersoaneDTO();
                        cdto.Id = cc.Id;
                        cdto.nume_persoana = cc.nume_persoana;
                        cdto.del = cc.del;
                        pd.Persoanes.Add(cdto);
                    }
                    foreach (var cc in item.Useris)
                    {
                        UseriDTO cdto = new UseriDTO();
                        cdto.Id = cc.Id;
                        cdto.nume_complet = cc.nume_complet;
                        cdto.mail = cc.mail;
                        cdto.parola = cc.parola;
                        cdto.del = cc.del;
                        pd.Useris.Add(cdto);
                    }

                    Files.Add(pd);
                }
            }
            else if (string.IsNullOrEmpty(SearchString) && !string.IsNullOrEmpty(SearchPeisaj) && string.IsNullOrEmpty(SearchEveniment))
            {
                var files = await pcc.GetFilesByPeisajAsync(SearchPeisaj);
                foreach (var item in files)
                {
                    // Trebuia folosit AutoMapper. Transform Post in PostDTO
                    FilesDTO pd = new FilesDTO();
                    pd.Id = item.Id;
                    pd.nume_fisier = item.nume_fisier;
                    pd.cale = item.cale;
                    pd.data_creare = item.data_creare;
                    pd.locatie = item.locatie;
                    pd.eveniment = item.eveniment;
                    pd.peisaj = item.peisaj;
                    pd.descriere = item.descriere;
                    pd.del = item.del;
                    foreach (var cc in item.Persoanes)
                    {
                        PersoaneDTO cdto = new PersoaneDTO();
                        cdto.Id = cc.Id;
                        cdto.nume_persoana = cc.nume_persoana;
                        cdto.del = cc.del;
                        pd.Persoanes.Add(cdto);
                    }
                    foreach (var cc in item.Useris)
                    {
                        UseriDTO cdto = new UseriDTO();
                        cdto.Id = cc.Id;
                        cdto.nume_complet = cc.nume_complet;
                        cdto.mail = cc.mail;
                        cdto.parola = cc.parola;
                        cdto.del = cc.del;
                        pd.Useris.Add(cdto);
                    }

                    Files.Add(pd);
                }
            }
            else if (string.IsNullOrEmpty(SearchString) && string.IsNullOrEmpty(SearchPeisaj) && !string.IsNullOrEmpty(SearchEveniment))
            {
                var files = await pcc.GetFilesByEvenimentAsync(SearchEveniment);
                foreach (var item in files)
                {
                    // Trebuia folosit AutoMapper. Transform Post in PostDTO
                    FilesDTO pd = new FilesDTO();
                    pd.Id = item.Id;
                    pd.nume_fisier = item.nume_fisier;
                    pd.cale = item.cale;
                    pd.data_creare = item.data_creare;
                    pd.locatie = item.locatie;
                    pd.eveniment = item.eveniment;
                    pd.peisaj = item.peisaj;
                    pd.descriere = item.descriere;
                    pd.del = item.del;
                    foreach (var cc in item.Persoanes)
                    {
                        PersoaneDTO cdto = new PersoaneDTO();
                        cdto.Id = cc.Id;
                        cdto.nume_persoana = cc.nume_persoana;
                        cdto.del = cc.del;
                        pd.Persoanes.Add(cdto);
                    }
                    foreach (var cc in item.Useris)
                    {
                        UseriDTO cdto = new UseriDTO();
                        cdto.Id = cc.Id;
                        cdto.nume_complet = cc.nume_complet;
                        cdto.mail = cc.mail;
                        cdto.parola = cc.parola;
                        cdto.del = cc.del;
                        pd.Useris.Add(cdto);
                    }

                    Files.Add(pd);
                }
            }
        }
    }
    }

