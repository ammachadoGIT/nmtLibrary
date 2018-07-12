using nmtLibrary.General.Models;
using nmtLibrary.General.Interfaces;
using System.Collections.Generic;

namespace nmtLibrary.Services
{
    public class WriterService : IWriterService, IWriterRepository, IBookRepository
    {
        private IWriterRepository writerRepository;
        private IBookRepository bookRepository;

        public WriterService(IWriterRepository writerRepository, IBookRepository bookRepository)
        {
            this.writerRepository = writerRepository;
            this.bookRepository = bookRepository;
        }

        public IEnumerable<Writer> ListAll()
        {
            return writerRepository.ListAll();
        }

        public IEnumerable<Book> ListBooksByWriter(int id)
        {
            return bookRepository.ListBooksByWriter(id);
        }
    }
}
