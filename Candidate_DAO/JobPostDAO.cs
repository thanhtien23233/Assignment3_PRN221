using Candidate_BusinessObjects.Models;
using Newtonsoft.Json;

namespace Candidate_DAO
{
    public class JobPostDAO
    {
        static string relativePath = @"..\..\..\..\Candidate_DAO\Data\jobposting.json";
        static string filePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), relativePath));
        private static JobPostDAO instance = null;

        public static JobPostDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobPostDAO();
                }
                return instance;
            }
        }

        private List<JobPosting> LoadData()
        {
            if (!File.Exists(filePath))
            {
                return new List<JobPosting>();
            }

            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<JobPosting>>(jsonData) ?? new List<JobPosting>();
        }

        private void WriteData(List<JobPosting> jobPostings)
        {
            string jsonData = JsonConvert.SerializeObject(jobPostings, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        public List<JobPosting> GetJobPostings()
        {
            return LoadData();
        }

        public JobPosting GetJobPosting(string id)
        {
            List<JobPosting> jobPostings = LoadData();
            return jobPostings.SingleOrDefault(m => m.PostingId.Equals(id));
        }

        public void AddJobPosting(JobPosting jobPosting)
        {
            List<JobPosting> jobPostings = LoadData();
            if (!jobPostings.Any(j => j.PostingId == jobPosting.PostingId))
            {
                jobPostings.Add(jobPosting);
                WriteData(jobPostings);
            }
        }

        public void UpdateJobPosting(JobPosting jobPosting)
        {
            List<JobPosting> jobPostings = LoadData();
            var existingPosting = jobPostings.SingleOrDefault(j => j.PostingId == jobPosting.PostingId);
            if (existingPosting != null)
            {
                jobPostings.Remove(existingPosting);
                jobPostings.Add(jobPosting);
                WriteData(jobPostings);
            }
        }

        public void DeleteJobPosting(string id)
        {
            List<JobPosting> jobPostings = LoadData();
            var jobPosting = jobPostings.SingleOrDefault(j => j.PostingId == id);
            if (jobPosting != null)
            {
                jobPostings.Remove(jobPosting);
                WriteData(jobPostings);
            }
        }
    }
}
