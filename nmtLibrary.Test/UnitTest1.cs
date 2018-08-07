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

            writerRepository.ListAll().Returns(writers);

            IEnumerable<Writer> result = writerService.ListAll();
            Assert.NotNull(result);
            Assert.Equal(5, result.Count());
        }

        [Fact]
        public void TestListBooksByWriter()
        {
            IEnumerable<Book> books = new List<Book> {
                    new Book {ID = 1, Title = "Title 1", WriterID = 1, Year = 1921 },
                    new Book {ID = 2, Title = "Title 2", WriterID = 1, Year = 1921 },
                };

            bookRepository.ListBooksByWriter(1).Returns(books);

            IEnumerable<Book> result = writerService.ListBooksByWriter(1);
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
        }
    }
}
