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
        private readonly IWriterRepository writerRepository;
        private readonly IBookRepository bookRepository;

        public WritersAPIController(IWriterRepository writerRepository, IBookRepository bookRepository)
        {
            this.writerRepository = writerRepository;
            this.bookRepository = bookRepository;
        }

        // GET: api/Writers
        [HttpGet]
        public IEnumerable<Writer> Writers()
        {
            return writerRepository.ListAll();
        }

        // GET: api/Writers/5/Books
        [HttpGet("{id}/Books")]
        public IEnumerable<Book> BooksByWriter([FromRoute] int id)
        {
            return bookRepository.ListBooksByWriter(id);
        }
    }
}