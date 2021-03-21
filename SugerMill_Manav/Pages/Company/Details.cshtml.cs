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
    public class DetailsModel : PageModel
    {
        private readonly SugerMill_Manav.Data.ApplicationDbContext _context;

        public DetailsModel(SugerMill_Manav.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public BussinessLayer.Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Companies.FirstOrDefaultAsync(m => m.ID == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
