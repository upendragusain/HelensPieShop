using HelensPieShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HelensPieShop.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public IActionResult Index()
        {
            return View(new Feedback());
        }

        [HttpPost]
        public async Task<IActionResult> Index(Feedback feedback)
        {
            if (!ModelState.IsValid)
            {
                //test
                //ModelState.AddModelError("Name", "this is a validation error from the server!");
                return View(feedback);
            }

            await _feedbackRepository.AddFeedback(Map(feedback));
            return RedirectToAction("FeedbackComplete");
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }

        private Infrastructure.Feedback Map(Feedback feedback)
        {
            return new Infrastructure.Feedback()
            {
                ContactMe = feedback.ContactMe,
                Email = feedback.Email,
                Message = feedback.Message,
                Name = feedback.Name
            };
        }
    }
}
