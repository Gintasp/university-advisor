using Advisor.Models;
using Advisor.Services.Statistics;
using System.Linq;
using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Advisor.Controllers
{
    public class ReviewController: Controller, IReviewController
    {
        public ReviewController()
        {
        }

        [Route("review", Name = "review_page")]
        public ActionResult Review()
        {
            return View("/Views/Review.cshtml");
        }

        public void HandleSubmitReviewButtonClick()
        {
        }

      public void SaveReview(Review review)
        {
        }
    }
}