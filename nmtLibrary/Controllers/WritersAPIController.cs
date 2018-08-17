using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using nmtLibrary.General.Models;
using nmtLibrary.General.Interfaces;

namespace nmtLibrary.Controllers
{
    [Produces("application/json")]
    [Route("api/Writers")]
    public class WritersAPIController : Controller
    {
        private readonly IWriterService writerService;

        public WritersAPIController(IWriterService writerService)
        {
            this.writerService = writerService;
        }

        // GET: api/Writers
        [HttpGet]
        public IEnumerable<Writer> Writers()
        {
            return writerService.ListAll();
        }

        // GET: api/Writers/5/Books
        [HttpGet("{id}/Books")]
        public IEnumerable<Book> BooksByWriter([FromRoute] int id)
        {
            return writerService.ListBooksByWriter(id);
        }
    }
}