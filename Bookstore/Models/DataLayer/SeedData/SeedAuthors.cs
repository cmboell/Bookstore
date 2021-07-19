using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//seed author model
namespace Bookstore.Models
{
    internal class SeedAuthors : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> entity)
        {
            entity.HasData(
                new Author { AuthorId = 4, FirstName = "Michelle", LastName = "Alexander" },
                new Author { AuthorId = 20, FirstName = "Stephen E.", LastName = "Ambrose" },
                new Author { AuthorId = 18, FirstName ="Guy", LastName = "BookWriter"},
                new Author { AuthorId = 25, FirstName ="Susan", LastName ="Besusan"},
                new Author { AuthorId = 26, FirstName = "Seth", LastName = "Grahame-Smith" }
            );
        }
    }

}