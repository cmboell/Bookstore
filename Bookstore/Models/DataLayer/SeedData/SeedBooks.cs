using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//seed book model
namespace Bookstore.Models
{
    internal class SeedBooks : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> entity)
        {
            entity.HasData(
                new Book { BookId = 1, Title = "1776", GenreId = "history", Price = 18.00 },
                new Book { BookId = 2, Title = "1984", GenreId = "scifi", Price = 5.50 },
                new Book { BookId = 29, Title = "Harry Potter and the Sorcerer's Stone", GenreId = "novel", Price = 9.75 },
                new Book { BookId = 28, Title = "Two Authors, One Book", GenreId ="novel", Price = 16.50}
            );
        }
    }

}
