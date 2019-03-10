

using System.Collections.Generic;
using addressBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace addressBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {

        private readonly AddressBookContext _context;

        public AddressBookController(AddressBookContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet]
        [Produces("application/json")]
        public List<AddressBook> Get()
        {
            return _context.AddressBooks.ToList();


        }
    }
}