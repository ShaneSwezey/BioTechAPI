using BioTechAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace BioTechAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsLetterController : ControllerBase
    {
        private readonly BioTechContext _context;

        public NewsLetterController(BioTechContext context)
        {
            _context = context ?? throw new ArgumentNullException();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(404)]
        public async Task<ActionResult<NewsLetter>> GetByIdAsync(int id)
        {
            var subscriber = await _context.NewsLetters.FirstOrDefaultAsync(n => n.SubscriberID == id);

            if (subscriber == null)
            {
                return NotFound();
            }

            return subscriber;
        }

        [HttpPost]
        [ProducesResponseType(400)]
        public async Task<ActionResult<NewsLetter>> CreateAsync([FromBody]string emailAddress)
        {
            
            if (await _context.NewsLetters.AnyAsync(n => n.EmailAddress.Equals(emailAddress)))
            {
                return BadRequest("Email address is already subscribed.");
            }

            var subscriber = new NewsLetter()
            {
                EmailAddress = emailAddress
            };

            await _context.NewsLetters.AddAsync(subscriber);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetByIdAsync), new { id = subscriber.SubscriberID }, subscriber);
        }

    }
}
