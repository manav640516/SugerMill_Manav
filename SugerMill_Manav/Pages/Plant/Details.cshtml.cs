using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SugerMill_Manav.BussinessLayer;
using SugerMill_Manav.Data;

namespace SugerMill_Manav.Pages.Plant
{
    public class DetailsModel : PageModel
    {
        private readonly SugerMill_Manav.Data.ApplicationDbContext _context;

        public DetailsModel(SugerMill_Manav.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public BussinessLayer.Plant Plant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plant = await _context.Plants.FirstOrDefaultAsync(m => m.ID == id);

            if (Plant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
