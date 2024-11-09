using Candidate_BusinessObjects.Models;
using Candidate_DAO;

class Program
{
    static void Main(string[] args)
    {
        ReadCandidateProfiles();
        ReadJobPostings();
        ReadHRAccount();
        GetCurrentDirectory();
    }
    private static void ReadCandidateProfiles()
    {
        List<CandidateProfile> candidates = CandidateProfileDAO.Instance.GetCandidateProfiles();
        if (candidates != null)
        {
            foreach (var candidate in candidates)
            {
                Console.WriteLine($"Candidate ID: {candidate.CandidateId}");
                Console.WriteLine($"Fullname: {candidate.Fullname}");
                Console.WriteLine($"Birthday: {candidate.Birthday}");
                Console.WriteLine($"Profile Short Description: {candidate.ProfileShortDescription}");
                Console.WriteLine($"Profile URL: {candidate.ProfileUrl}");
                Console.WriteLine($"Posting ID: {candidate.PostingId}");
                Console.WriteLine();
            }
        }
        else Console.WriteLine("No Data");
    }

    private static void ReadJobPostings()
    {
        List<JobPosting> jobPostings = JobPostDAO.Instance.GetJobPostings();

        if (jobPostings != null && jobPostings.Count > 0)
        {
            foreach (var jobPosting in jobPostings)
            {
                Console.WriteLine($"Posting ID: {jobPosting.PostingId}");
                Console.WriteLine($"Job Title: {jobPosting.JobPostingTitle}");
                Console.WriteLine($"Description: {jobPosting.Description ?? "No description provided"}");
                Console.WriteLine($"Posted Date: {(jobPosting.PostedDate.HasValue ? jobPosting.PostedDate.Value.ToString("yyyy-MM-dd") : "No date provided")}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No Job Posting Data");
        }
    }

    private static void ReadHRAccount()
    {
        List<Hraccount> hrAccounts = HRAccountDAO.Instance.GetHraccounts();

        if (hrAccounts != null && hrAccounts.Count > 0)
        {
            foreach (var account in hrAccounts)
            {
                Console.WriteLine($"Email: {account.Email}");
                Console.WriteLine($"Password: {account.Password ?? "No password provided"}");
                Console.WriteLine($"Full Name: {account.FullName ?? "No full name provided"}");
                Console.WriteLine($"Member Role: {(account.MemberRole.HasValue ? account.MemberRole.Value.ToString() : "No role provided")}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No HR Account Data");
        }
    }
    private static void GetCurrentDirectory()
    {
        // Define the relative path from your current directory to the JSON file
        string relativePath = @"..\..\..\..\Candidate_DAO\Data\candidateprofile.json";

        // Combine the current directory with the relative path
        string fullPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), relativePath));

        Console.WriteLine("Full Path: " + fullPath);
    }
}