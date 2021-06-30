using _1811061027.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1811061027.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var booklist = new List<Book>
            {
                new Book (){Bookid = 1, BookName = "abc",Page = 1 },
                new Book (){Bookid = 2, BookName = "bac",Page = 2 },
                new Book (){Bookid = 3, BookName = "acb",Page = 3 },
                new Book (){Bookid = 4, BookName = "cab",Page = 4 },
                new Book (){Bookid = 5, BookName = "cba",Page = 5 },

            };
            return View(booklist);
        }
    }
}
