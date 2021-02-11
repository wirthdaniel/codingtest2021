using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.Core;
using CodingTest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingTest.Pages
{
    public class SignUpModel : PageModel
    {
        private readonly IHtmlHelper _htmlHelper;

        private readonly ISubscriptionData _subscriptionData;

        public IEnumerable<SelectListItem> Sources { get; set; }

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Subscription Subscription { get; set; }

        public SignUpModel(IHtmlHelper htmlHelper, ISubscriptionData subscriptionData)
        {
            _htmlHelper = htmlHelper;
            _subscriptionData = subscriptionData;
        }
        public void OnGet()
        {
            Sources = _htmlHelper.GetEnumSelectList<SourceType>();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Sources = _htmlHelper.GetEnumSelectList<SourceType>();

            if (!ModelState.IsValid)
            {
                Sources = _htmlHelper.GetEnumSelectList<SourceType>();
                return Page();
            }

            if (_subscriptionData.GetSubscriptionByEmail(Subscription.Email) != null)
            {
                TempData["Message"] = "You are already signed up";

                return RedirectToPage();
            }
            else
            {
                await _subscriptionData.Add(Subscription);
                await _subscriptionData.Commit();
            }

            TempData["Message"] = "Signed up to the newsletter successfully";

            return RedirectToPage("./Success");
        }
    }
}
