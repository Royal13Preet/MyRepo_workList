using Contact_Management.DataAccess;
using Contact_Management.DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Contact_Management.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public readonly ContactDbContext _dbContext;

        public ContactController(ContactDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            return await _dbContext.Contacts.ToListAsync();
        }
        
        [HttpPost]
        public async Task<ActionResult<Contact>> CreateContact(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetContacts), new { id = contact.Id }, contact);
        }
      
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContactById(int id)
        {
            var contact = await _dbContext.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContact(int id, Contact updatedContact)
        {
            var contact = await _dbContext.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound("Contact not found.");
            }
            
            contact.Name = updatedContact.Name;
            contact.PhoneNumber = updatedContact.PhoneNumber;
            contact.Email = updatedContact.Email;

            await _dbContext.SaveChangesAsync();
            return Ok("Updated succefully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await _dbContext.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            _dbContext.Contacts.Remove(contact);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }

       
    }
}
