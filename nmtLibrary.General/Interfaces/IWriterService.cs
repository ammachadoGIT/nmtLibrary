using nmtLibrary.General.Models;
using System.Collections.Generic;

namespace nmtLibrary.General.Interfaces
{
    public interface IWriterService
    {
        IEnumerable<Writer> ListAll();
    }
}