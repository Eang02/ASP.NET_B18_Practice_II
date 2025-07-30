using Microsoft.AspNetCore.Mvc;

namespace MyFirstMvcApp.Controllers
{
    public class BooksController : Controller
    {
        // This is the Index method as updated in Exercise 3.1
        // (Originally it returned View(), but was changed to return Content)
        public IActionResult Index()
        {
            return Content("This is the book index page.");
        }

        // This is the All method as updated in Exercise 3.1.
        // The previous "return View()" version should be removed.
        public IActionResult All()
        {
            return Content("<h1>Here is a list of ALL books!</h1>", "text/html");
            // Note: We can even return basic HTML this way by specifying the content type.
        }

        // This is the Details method as updated in Exercise 3.3 to accept an 'id' parameter.
        // The previous "public IActionResult Details() { return View(); }" version must be removed.
        public IActionResult Details(int id)
        {
            // For now, just display the ID that was passed in.
            return Content($"Showing details for book with ID: {id}");
        }

        // This is the OldCatalog method from Exercise 3.2, which redirects to the All action.
        public IActionResult OldCatalog()
        {
            // This tells the browser to make a new request to the "/Books/All" URL.
            return RedirectToAction("All", "Books");
        }
    }
}