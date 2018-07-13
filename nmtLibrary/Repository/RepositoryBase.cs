using nmtLibrary.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace nmtLibrary.Repository
{
    public abstract class RepositoryBase<T> where T : class
    {
        protected LibraryContext LibraryContext { get; set; }

        protected IQueryable<T> DbQuery
        {
            get
            {
                return LibraryContext.Set<T>().AsQueryable();
            }
        }

        public RepositoryBase(LibraryContext libraryContext)
        {
            LibraryContext = libraryContext;
        }
    }
}
