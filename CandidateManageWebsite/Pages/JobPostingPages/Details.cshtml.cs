using Candidate_BusinessObjects.Models;
using Candidate_Services.JobPostingService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManageWebsite.Pages.JobPostingPages
{
    public class DetailsModel : PageModel
    {
        private readonly IJobPostingService _jobPostingService;

        public DetailsModel(IJobPostingService jobPostingService)
        {
            _jobPostingService = jobPostingService;
        }

        public JobPosting JobPosting { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobposting = _jobPostingService.GetJobPosting(id);
            if (jobposting == null)
            {
                return NotFound();
            }
            else
            {
                JobPosting = jobposting;
            }
            return Page();
        }
    }
}
