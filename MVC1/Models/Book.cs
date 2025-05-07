
namespace MVC1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        public int PublishedYear { get; set; }
        public string? Markup { get; set; } 

        

        // Static method to generate a list of books
        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Genre = "Classic",
                    Price = 10.99m,
                    PublishedYear = 1925,
                    Markup = "<p>A classic novel set in the Roaring Twenties.</p>"
                },
                new Book
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Genre = "Fiction",
                    Price = 12.99m,
                    PublishedYear = 1960,
                    Markup = "<p>A story of racial injustice and childhood innocence.</p>"
                },
                new Book
                {
                    Id = 3,
                    Title = "1984",
                    Author = "George Orwell",
                    Genre = "Dystopian",
                    Price = 9.99m,
                    PublishedYear = 1949,
                    Markup = "<p>A chilling vision of a totalitarian future.</p>"
                },
                new Book
                {
                    Id = 4,
                    Title = "Moby-Dick",
                    Author = "Herman Melville",
                    Genre = "Adventure",
                    Price = 14.99m,
                    PublishedYear = 1851,
                    Markup = "<p>An epic tale of obsession and revenge at sea.</p>"
                }
            };
        }
    }
}
