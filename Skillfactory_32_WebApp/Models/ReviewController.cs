using Microsoft.AspNetCore.Mvc;

namespace Skillfactory_32_WebApp.Models
{
    public class ReviewController: Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Review review)
        {
            return StatusCode(200, $"{review.From}, спасибо за отзыв!");
        }
    }
}
