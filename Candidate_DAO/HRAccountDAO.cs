using Candidate_BusinessObjects.Models;
using Newtonsoft.Json;

namespace Candidate_DAO
{
    public class HRAccountDAO
    {
        static string relativePath = @"..\..\..\..\Candidate_DAO\Data\hraccount.json";
        static string filePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), relativePath));
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
