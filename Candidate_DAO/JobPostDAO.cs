﻿using Candidate_BusinessObjects.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Candidate_DAO
{
    public class JobPostDAO
    {
        private static readonly string
            filePath = "C:/Users/thanhtien/Desktop/Assignment3_PRN221" +
            "/Candidate_BusinessObject/Data/jobposting.json";
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