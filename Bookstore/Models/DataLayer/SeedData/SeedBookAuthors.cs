using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//seed book author model
namespace Bookstore.Models
{
    internal class SeedBookAuthors : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> entity)
        {
            entity.HasData(
                new BookAuthor { BookId = 1, AuthorId = 18 },
                new BookAuthor { BookId = 2, AuthorId = 20 },
                new BookAuthor { BookId = 28, AuthorId = 4 },
                new BookAuthor { BookId = 28, AuthorId = 26 },
                new BookAuthor { BookId = 29, AuthorId = 25 }
                 
            );
        }
    }

}
