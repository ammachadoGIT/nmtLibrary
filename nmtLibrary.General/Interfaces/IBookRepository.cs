using nmtLibrary.General.Models;
using System.Collections.Generic;

namespace nmtLibrary.General.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> ListBooksByWriter(int id);
    }
}