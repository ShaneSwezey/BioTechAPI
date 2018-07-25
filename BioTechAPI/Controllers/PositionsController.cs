using BioTechAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : Controller
    {
        private BioTechContext _context;

        public PositionsController(BioTechContext context)
        {
            _context = context;
        }

        // api/positions/
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Position))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get()
        {
            var positionList = await _context.Positions.OrderBy(p => p.PostDate)
                .Include(p => p.Qualifications)
                .Include(p => p.Responsibilites)
                .Include(p => p.Experiences)
                .Include(p => p.Education)
                .ToListAsync();
            if (positionList == null)
            {
                return NotFound("No positions are available at this time.");
            }

            return Ok(positionList);
        }

    }
}
