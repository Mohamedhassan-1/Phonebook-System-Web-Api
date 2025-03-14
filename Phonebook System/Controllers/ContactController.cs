using Domain_Layer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service_Layer.ICustomServices;

namespace Phonebook_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactServices _contactServices;

        public ContactController(IContactServices contactServices)
        {
            this._contactServices = contactServices;
        }
        [HttpGet]
        public ActionResult getAll()
        {
            var obj = _contactServices.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
             return Ok(obj);
        }
        [HttpGet("/{id:int}")]
        public ActionResult getById(int id)
        {
            var obj = _contactServices.Get(id);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }

        [HttpPost("/Create")]
        public ActionResult Create(Contact contact)
        {
            if (contact != null)
            {
                _contactServices.Insert(contact);
                return Ok("Created Successfully");
            }
            return BadRequest("Somethingwent wrong");
        }

        [HttpPost("/Update")]
        public ActionResult UpdateStudent(Contact contact)
        {
            if (contact != null)
            {
                _contactServices.Update(contact);
                return Ok("Updated SuccessFully");
            }
            return BadRequest();
            
        }
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {     
            if(_contactServices.Delete(id))
            return Ok("Deleted Successfully");
            return BadRequest("Something went wrong");
            
        }
    }
}
