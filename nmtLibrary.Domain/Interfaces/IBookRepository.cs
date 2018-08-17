using nmtLibrary.Domain.Models;
using System.Collections.Generic;

namespace nmtLibrary.Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> ListBooksByWriter(int id);
    }
}