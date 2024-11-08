using Candidate_BusinessObjects.Models;
using Candidate_Services.CandidateService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManageWebsite.Pages.CandidateProfilePages
{
    public class DetailsModel : PageModel
    {
        private readonly ICandidateService candidateService;

        public DetailsModel(ICandidateService candidate)
        {
            candidateService = candidate;
        }

        public CandidateProfile CandidateProfile { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidateprofile = candidateService.GetCandidateProfile(id);
            if (candidateprofile == null)
            {
                return NotFound();
            }
            else
            {
                CandidateProfile = candidateprofile;
            }
            return Page();
        }
    }
}
