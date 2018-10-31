namespace _08_CompanyUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class CompanyUsers
    {
        public static void Main()
        {
            var companyAndUsers = new Dictionary<string, List<string>>();

            while (true)
            {
                var companyUsers = Console.ReadLine().Split("->");

                if (companyUsers[0] == "End")
                {
                    break;
                }
                var company = companyUsers[0];
                var employee = companyUsers[1];

                if (!companyAndUsers.ContainsKey(company))
                {
                    companyAndUsers.Add(company, new List<string>());
                    companyAndUsers[company].Add(employee);
                }
                else
                {
                    if (!companyAndUsers[company].Contains(employee))
                    {
                        companyAndUsers[company].Add(employee);
                    }
                }

            }
            foreach (var company in companyAndUsers.OrderBy(c => c.Key))
            {
                var users = companyAndUsers[company.Key];
                Console.WriteLine(company.Key);
                for (int i = 0; i < users.Count; i++)
                {
                    Console.WriteLine($"--{users[i]}");
                }
            }
        }
    }
}
