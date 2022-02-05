using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingAppProject.Server.Data;
using DatingAppProject.Shared.Domain;
using DatingAppProject.Server.IRepository;

namespace DatingAppProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        //publicMeetingsController(ApplicationDbContext context)
        public MeetingsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Meetings
        [HttpGet]
        public async Task<IActionResult> GetMeetings()
        {
            //return await _context.Meetings.ToListAsync();
            var meetings = await _unitOfWork.Meetings.GetAll(includes: q => q.Include(x => x.Host).Include(x => x.Participant));
            return Ok(meetings);
        }

        // GET: api/Meetings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meeting>> GetMeeting(int id)
        {
            //var meeting = await _context.Meetings.FindAsync(id);
            var meeting = await _unitOfWork.Meetings.Get(q => q.Id == id);

            if (meeting == null)
            {
                return NotFound();
            }

            //return meeting;
            return Ok(meeting);
        }

        // PUT: api/Meetings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeeting(int id, Meeting meeting)
        {
            if (id != meeting.Id)
            {
                return BadRequest();
            }

            //_context.Entry(meeting).State = EntityState.Modified;
            _unitOfWork.Meetings.Update(meeting);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MeetingExists(id))
                if (!await MeetingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Meetings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Meeting>> PostMeeting(Meeting meeting)
        {
            //_context.Meetings.Add(meeting);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Meetings.Insert(meeting);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetMeeting", new { id = meeting.Id }, meeting);
        }

        // DELETE: api/Meetings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeeting(int id)
        {
            //var meeting = await _context.Meetings.FindAsync(id);
            var meeting = await _unitOfWork.Meetings.Get(q => q.Id == id);
            if (meeting == null)
            {
                return NotFound();
            }

            //_context.Meetings.Remove(meeting);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Meetings.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> MeetingExists(int id)
        {
            //return _context.Meetings.Any(e => e.Id == id);
            var meeting = await _unitOfWork.Meetings.Get(q => q.Id == id);
            return meeting != null;
        }
    }
}
