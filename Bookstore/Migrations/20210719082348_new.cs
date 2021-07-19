using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 8, 16 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 10, 20 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 11, 15 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 13, 21 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 15, 9 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 16, 13 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 19, 11 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 20, 22 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 21, 17 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 22, 3 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 23, 14 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 25, 10 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "BookId", "AuthorId" },
                keyValues: new object[] { 27, 23 });

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Michelle", "Alexander" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Guy", "BookWriter" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Stephen E.", "Ambrose" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 25,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Susan", "Besusan" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "Price", "Title" },
                values: new object[] { 16.5, "Two Authors, One Book" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jane", "Austen" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "David", "McCullough" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "George", "Orwell" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 25,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "JK", "Rowling" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 23, "Augusten", "Burroughs" },
                    { 22, "Sun", "Tzu" },
                    { 21, "Mary", "Shelley" },
                    { 19, "Toni", "Morrison" },
                    { 17, "Stieg", "Larsson" },
                    { 16, "Aldous", "Huxley" },
                    { 15, "Frank", "Herbert" },
                    { 14, "Dashiel", "Hammett" },
                    { 1, "Michelle", "Alexander" },
                    { 12, "Tina", "Fey" },
                    { 11, "Daphne", "Du Maurier" },
                    { 10, "Joan", "Didion" },
                    { 9, "Jared", "Diamond" },
                    { 8, "Ta-Nehisi", "Coates" },
                    { 7, "Agatha", "Christie" },
                    { 6, "Emily", "Bronte" },
                    { 2, "Stephen E.", "Ambrose" },
                    { 3, "Margaret", "Atwood" },
                    { 5, "James", "Baldwin" },
                    { 13, "Roxane", "Gay" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28,
                columns: new[] { "Price", "Title" },
                values: new object[] { 8.75, "Pride and Prejudice and Zombies" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { 20, "history", 5.75, "The Art of War" },
                    { 21, "mystery", 8.5, "The Girl with the Dragon Tattoo" },
                    { 22, "scifi", 12.5, "The Handmaid's Tale" },
                    { 27, "memoir", 11.0, "Running With Scissors" },
                    { 24, "history", 13.75, "The New Jim Crow" },
                    { 25, "memoir", 13.5, "The Year of Magical Thinking" },
                    { 26, "novel", 9.0, "Wuthering Heights" },
                    { 19, "mystery", 10.99, "Rebecca" },
                    { 23, "mystery", 10.99, "The Maltese Falcon" },
                    { 18, "novel", 8.5, "Pride and Prejudice" },
                    { 14, "novel", 10.25, "Go Tell it on the Mountain" },
                    { 16, "memoir", 14.5, "Hunger" },
                    { 15, "history", 15.5, "Guns, Germs, and Steel" },
                    { 13, "scifi", 6.5, "Frankenstein" },
                    { 12, "novel", 9.0, "Emma" },
                    { 11, "scifi", 8.75, "Dune" },
                    { 10, "memoir", 12.5, "Down and Out in Paris and London" },
                    { 9, "history", 15.0, "D-Day" },
                    { 8, "scifi", 16.25, "Brave New World" },
                    { 6, "memoir", 13.5, "Between the World and Me" },
                    { 5, "novel", 10.99, "Beloved" },
                    { 4, "history", 11.5, "Band of Brothers" },
                    { 3, "mystery", 4.5, "And Then There Were None" },
                    { 17, "mystery", 6.75, "Murder on the Orient Express" },
                    { 7, "memoir", 4.25, "Bossypants" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "BookId", "AuthorId" },
                values: new object[,]
                {
                    { 3, 7 },
                    { 25, 10 },
                    { 24, 1 },
                    { 23, 14 },
                    { 22, 3 },
                    { 21, 17 },
                    { 20, 22 },
                    { 19, 11 },
                    { 18, 4 },
                    { 17, 7 },
                    { 16, 13 },
                    { 26, 6 },
                    { 15, 9 },
                    { 13, 21 },
                    { 12, 4 },
                    { 11, 15 },
                    { 10, 20 },
                    { 9, 2 },
                    { 8, 16 },
                    { 7, 12 },
                    { 6, 8 },
                    { 5, 19 },
                    { 4, 2 },
                    { 14, 5 },
                    { 27, 23 }
                });
        }
    }
}
