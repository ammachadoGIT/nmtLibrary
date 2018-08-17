using System.Collections.Generic;
using System.Linq;
using nmtLibrary.Data;
using nmtLibrary.Domain.Interfaces;
using nmtLibrary.Domain.Models;
using nmtLibrary.Repository;

namespace nmtLibrary.Data.Repository
{
    public class WriterRepository : RepositoryBase<Writer>, IWriterRepository
    {
        public WriterRepository(LibraryContext libraryContext) : base(libraryContext) { }

        public IEnumerable<Writer> ListAll()
        {
            IQueryable<Writer> writers = DbQuery;
            return writers.OrderBy(obj => obj.Name);
        }
    }
}
