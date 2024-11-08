using Candidate_BusinessObjects.Models;
using Candidate_Services.CandidateService;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManageWebsite.Pages.CandidateProfilePages
{
    public class IndexModel : PageModel
    {
        private readonly ICandidateService candidateService;

        public IndexModel(ICandidateService candidate)
        {
            candidateService = candidate;
        }

        public IList<CandidateProfile> CandidateProfile { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (candidateService.GetCandidateProfiles() != null)
            {
                CandidateProfile = candidateService.GetCandidateProfiles();
            }
        }
    }
}
