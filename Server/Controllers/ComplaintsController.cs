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
    public class ComplaintsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        //public ComplaintsController(ApplicationDbContext context)
        public ComplaintsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Complaints
        [HttpGet]
        public async Task<IActionResult> GetComplaints()
        {
            //return await _context.Complaints.ToListAsync();
            var complaints = await _unitOfWork.Complaints.GetAll(includes: q => q.Include(x => x.Staff).Include(x => x.Customer));
            return Ok(complaints);
        }

        // GET: api/Complaints/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Complaint>> GetComplaint(int id)
        {
            //var complaint = await _context.Complaints.FindAsync(id);
            var complaint = await _unitOfWork.Complaints.Get(q => q.Id == id);

            if (complaint == null)
            {
                return NotFound();
            }

            //return complaint;
            return Ok(complaint);
        }

        // PUT: api/Complaints/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplaint(int id, Complaint complaint)
        {
            if (id != complaint.Id)
            {
                return BadRequest();
            }

            //_context.Entry(complaint).State = EntityState.Modified;
            _unitOfWork.Complaints.Update(complaint);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!ComplaintExists(id))
                if (!await ComplaintExists(id))
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

        // POST: api/Complaints
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Complaint>> PostComplaint(Complaint complaint)
        {
            //_context.Complaints.Add(complaint);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Complaints.Insert(complaint);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetComplaint", new { id = complaint.Id }, complaint);
        }

        // DELETE: api/Complaints/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplaint(int id)
        {
            //var complaint = await _context.Complaints.FindAsync(id);
            var complaint = await _unitOfWork.Complaints.Get(q => q.Id == id);
            if (complaint == null)
            {
                return NotFound();
            }

            //_context.Complaints.Remove(complaint);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Complaints.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> ComplaintExists(int id)
        {
            //return _context.Complaints.Any(e => e.Id == id);
            var complaint = await _unitOfWork.Complaints.Get(q => q.Id == id);
            return complaint != null;
        }
    }
}