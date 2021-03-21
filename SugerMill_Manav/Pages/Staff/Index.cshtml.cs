using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SugerMill_Manav.BussinessLayer;
using SugerMill_Manav.Data;

namespace SugerMill_Manav.Pages.Staff
{
    public class IndexModel : PageModel
    {
        private readonly SugerMill_Manav.Data.ApplicationDbContext _context;

        public IndexModel(SugerMill_Manav.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<BussinessLayer.Staff> Staff { get;set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staffs
                .Include(s => s.Company)
                .Include(s => s.Plant).ToListAsync();
        }
    }
}
