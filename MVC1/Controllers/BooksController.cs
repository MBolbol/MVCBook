using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class BooksController : Controller
    {
        public static List<Book> _books = Book.GetBooks();

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View(_books);
        //}
        [HttpGet]
        public IActionResult Details()
        {
            return View(_books);
        }
        //public IActionResult Details(int id)
        //{
        //    var book = _books.FirstOrDefault(b => b.Id == id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(book);
        //}
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddBookDto bookDto)
        {
            if (!ModelState.IsValid)
            {
                return View(bookDto);
            }
            var book = new Book
            {
                Id = _books.Max(b => b.Id) + 1,
                Title = bookDto.Name,
                Author = bookDto.Author,
                Price = bookDto.Price

            };
            _books.Add(book);
            //Console.WriteLine($"Added Book: {book.Title}, Total Books: {_books.Count}");
            return View("Details", _books);

            //return CreatedAtAction(nameof(Details), new { id = book.Id }, book);
            //return RedirectToAction(nameof(Index), _books);
        }

    }
}
