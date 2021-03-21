using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SugerMill_Manav.BussinessLayer;
using SugerMill_Manav.Data;

namespace SugerMill_Manav.Pages.Company
{
    public class IndexModel : PageModel
    {
        private readonly SugerMill_Manav.Data.ApplicationDbContext _context;

        public IndexModel(SugerMill_Manav.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<BussinessLayer.Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Companies.ToListAsync();
        }
    }
}
