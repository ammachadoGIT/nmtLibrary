﻿using System.Collections.Generic;
using System.Linq;
using nmtLibrary.Data;
using nmtLibrary.Domain.Interfaces;
using nmtLibrary.Domain.Models;
using nmtLibrary.Repository;

namespace nmtLibrary.Data.Repository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(LibraryContext libraryContext) : base(libraryContext) { }

        public IEnumerable<Book> ListBooksByWriter(int writerID)
        {
            IQueryable<Book> books = DbQuery.Where(o => o.WriterID == writerID);
            return books.OrderBy(obj => obj.Year);
        }
    }
}
