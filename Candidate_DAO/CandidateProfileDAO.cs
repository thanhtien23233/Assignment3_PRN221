using Candidate_BusinessObjects.Models;
using Newtonsoft.Json;

namespace Candidate_DAO
{
    public class CandidateProfileDAO
    {
        //private static readonly string filePath = "Your File Here";
        private static readonly string
            filePath = "C:/Users/thanhtien/Desktop/Assignment3_PRN221" +
            "/Candidate_BusinessObject/Data/candidateprofiles.json";
        public static CandidateProfileDAO instance = null;

        public static CandidateProfileDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDAO();
                }
                return instance;
            }
        }

        private List<CandidateProfile> LoadData()
        {
            if (!File.Exists(filePath))
            {
                return new List<CandidateProfile>();
            }

            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<CandidateProfile>>(jsonData) ?? new List<CandidateProfile>();
        }

        private void WriteData(List<CandidateProfile> candidates)
        {
            string jsonData = JsonConvert.SerializeObject(candidates, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            List<CandidateProfile> candidates = LoadData();
            foreach (var candidateProfile in candidates)
            {
                candidateProfile.Posting = JobPostDAO.Instance.GetJobPosting(candidateProfile.PostingId);
            }
            return candidates;
        }

        public CandidateProfile GetCandidateProfile(string candidateID)
        {
            List<CandidateProfile> candidates = LoadData();
            var candidate = candidates.SingleOrDefault(m => m.CandidateId.Equals(candidateID));
            if (candidate != null)
            {
                candidate.Posting = JobPostDAO.Instance.GetJobPosting(candidate.PostingId);
            }
            return candidate;
        }

        public List<string> GetPostingIds()
        {
            // Assuming JobPostDAO still reads from a file or another source
            var jobPostings = JobPostDAO.Instance.GetJobPostings();
            return jobPostings.Select(job => $"{job.PostingId} ({job.JobPostingTitle})").ToList();
        }

        public bool AddCandidateProfile(CandidateProfile candidate)
        {
            var candidates = LoadData();
            if (candidates.Any(c => c.CandidateId == candidate.CandidateId))
            {
                return false; // Candidate already exists
            }

            candidate.Posting = null;
            candidates.Add(candidate);
            WriteData(candidates);
            return true;
        }

        public bool UpdateCandidateProfile(CandidateProfile candidate)
        {
            var candidates = LoadData();
            var existingProfile = candidates.SingleOrDefault(c => c.CandidateId == candidate.CandidateId);
            if (existingProfile != null)
            {
                candidates.Remove(existingProfile);
                candidate.Posting = null;
                candidates.Add(candidate);
                WriteData(candidates);
                return true;
            }
            return false;
        }

        public bool DeleteCandidateProfile(string candidateID)
        {
            var candidates = LoadData();
            var candidate = candidates.SingleOrDefault(c => c.CandidateId == candidateID);
            if (candidate != null)
            {
                candidates.Remove(candidate);
                WriteData(candidates);
                return true;
            }
            return false;
        }
    }
}
