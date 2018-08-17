using nmtLibrary.Domain.Models;
using System.Collections.Generic;

namespace nmtLibrary.Domain.Interfaces
{
    public interface IWriterRepository
    {
        IEnumerable<Writer> ListAll();
    }
}