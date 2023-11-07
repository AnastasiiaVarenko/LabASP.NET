using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class PostController : Controller
    {
        static readonly Dictionary<int, Post> _posts = new Dictionary<int, Post>();
        static int id = 1;
        public IActionResult Index()
        {
            return View(_posts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post _model)
        {
            if (ModelState.IsValid)
            {
                _model.Id = id++;
                _posts[_model.Id] = _model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_posts[id]);
        }

        [HttpPost]
        public IActionResult Update(Post _model)
        {
            if (ModelState.IsValid)
            {
                _posts[_model.Id] = _model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_posts[id]);
        }

        [HttpPost]
        public IActionResult Delete(Post _model)
        {
            _posts.Remove(_model.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_posts[id]);
        }

        [HttpPost]
        public IActionResult Details(Post _model)
        {
            return RedirectToAction("Index");
        }
    }
}
