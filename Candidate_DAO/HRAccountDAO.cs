using Candidate_BusinessObjects.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Candidate_DAO
{
    public class HRAccountDAO
    {
        private static readonly string
            filePath = "C:/Users/thanhtien/Desktop/Assignment3_PRN221" +
            "/Candidate_BusinessObject/Data/hraccount.json";
        private static HRAccountDAO instance = null;

        public static HRAccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HRAccountDAO();
                }
                return instance;
            }
        }

        private List<Hraccount> LoadData()
        {
            if (!File.Exists(filePath))
            {
                return new List<Hraccount>();
            }

            string jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Hraccount>>(jsonData) ?? new List<Hraccount>();
        }

        private void WriteData(List<Hraccount> hrAccounts)
        {
            string jsonData = JsonConvert.SerializeObject(hrAccounts, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        public Hraccount GetHraccountByEmail(string email)
        {
            List<Hraccount> hrAccounts = LoadData();
            return hrAccounts.SingleOrDefault(m => m.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public List<Hraccount> GetHraccounts()
        {
            return LoadData();
        }
    }
}
