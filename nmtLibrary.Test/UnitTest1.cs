using nmtLibrary.General.Interfaces;
using nmtLibrary.General.Models;
using nmtLibrary.Services;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Xunit;

namespace nmtLibrary.Test
{
    public class UnitTest1
    {
        private readonly IBookRepository bookRepository;
        private readonly IWriterRepository writerRepository;
        private WriterService writerService;

        public UnitTest1()
        {
            bookRepository = Substitute.For<IBookRepository>();
            writerRepository = Substitute.For<IWriterRepository>();
            writerService = new WriterService(writerRepository, bookRepository);
        }

        [Fact]
        public void TestListWriter()
        {
            IQueryable<Writer> writers = new List<Writer> {
                    new Writer {ID = 1, DateOfBirth = new DateTime(1901, 01, 01), Name = "John"},
                    new Writer {ID = 2, DateOfBirth = new DateTime(1902, 02, 02), Name = "Jack"},
                    new Writer {ID = 3, DateOfBirth = new DateTime(1903, 03, 03), Name = "Josh"},
                    new Writer {ID = 4, DateOfBirth = new DateTime(1904, 04, 04), Name = "Joan"},
                    new Writer {ID = 5, DateOfBirth = new DateTime(1905, 05, 05), Name = "Jimmy"}
                }.AsQueryable();

            IDbSet<Writer> writerDbSet = Substitute.For<IDbSet<Writer>>();
            writerDbSet.Provider.Returns(writers.Provider);
            writerDbSet.Expression.Returns(writers.Expression);
            writerDbSet.ElementType.Returns(writers.ElementType);
            writerDbSet.GetEnumerator().Returns(writers.GetEnumerator());

            writerService.ListAll().Returns(writerDbSet);

            IEnumerable<Writer> result = writerService.ListAll();
            Assert.NotNull(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public void TestListBooksByWriter()
        {
            IQueryable<Book> books = new List<Book> {
                    new Book {ID = 1, Title = "Title 1", WriterID = 1, Year = 1921 },
                    new Book {ID = 2, Title = "Title 2", WriterID = 1, Year = 1921 },
                    new Book {ID = 3, Title = "Title 3", WriterID = 2, Year = 1922 },
                    new Book {ID = 4, Title = "Title 4", WriterID = 2, Year = 1922 },
                    new Book {ID = 5, Title = "Title 5", WriterID = 3, Year = 1923 },
                    new Book {ID = 6, Title = "Title 6", WriterID = 3, Year = 1926 }
                }.AsQueryable();


            IDbSet<Book> bookDbSet = Substitute.For<IDbSet<Book>>();
            bookDbSet.Provider.Returns(books.Provider);
            bookDbSet.Expression.Returns(books.Expression);
            bookDbSet.ElementType.Returns(books.ElementType);
            bookDbSet.GetEnumerator().Returns(books.GetEnumerator());

            writerService.ListBooksByWriter(1).Returns(bookDbSet);

            IEnumerable<Book> result = writerService.ListBooksByWriter(1);
            Assert.NotNull(result);
            Assert.Equal(6, result.Count());
        }
    }
}
