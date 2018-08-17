using nmtLibrary.Domain.Models;
using System.Collections.Generic;

namespace nmtLibrary.Domain.Interfaces
{
    public interface IWriterService
    {
        IEnumerable<Writer> ListAll();
        IEnumerable<Book> ListBooksByWriter(int id);
    }
}