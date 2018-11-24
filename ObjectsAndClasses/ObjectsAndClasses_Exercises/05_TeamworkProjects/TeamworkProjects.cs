namespace _05_TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        public string TeamNeam { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }


    }

    public class TeamworkProjects
    {
        public static void Main()
        {
            var newTeams = int.Parse(Console.ReadLine());
            var listOfTeams = new List<Team>();

            for (int i = 0; i < newTeams; i++)
            {
                var command = Console.ReadLine().Split("-");
                var creator = command[0];
                var team = command[1];

                var isTeamExist = listOfTeams.Any(t => t.TeamNeam == team);
                var isCreatorExist = listOfTeams.Any(c => c.Creator == creator);

                if (isTeamExist == false && isCreatorExist == false)
                {
                    Team newTeam = new Team()
                    {
                        TeamNeam = team,
                        Creator = creator,
                        Members = new List<string>()

                    };
                    listOfTeams.Add(newTeam);
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                }
                else if (isTeamExist)
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (isCreatorExist)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            }
            while (true)
            {
                var newMembers = Console.ReadLine().Split("->");

                if (newMembers[0] == "end of assignment")
                {
                    break;
                }

                var memberName = newMembers[0];
                var teamName = newMembers[1];
                var isTeamExist = listOfTeams.Any(t => t.TeamNeam == teamName);
                var isMemberExist = listOfTeams.Any(m => m.Members.Contains(memberName) || m.Creator == memberName);
                var isMemberAreCreator = listOfTeams.Any(x => x.Creator.Contains(memberName));
                if (isTeamExist == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (isMemberExist && isTeamExist )
                {
                    Console.WriteLine($"Member { memberName} cannot join team {teamName}!");
                    continue;
                }
                if (isTeamExist && isMemberExist == false)
                {
                    var indexOfTeam = listOfTeams.FindIndex(t => t.TeamNeam == teamName);
                    listOfTeams[indexOfTeam].Members.Add(memberName);
                }
            }
            var teamWithMembers = listOfTeams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamNeam)
                .ToList();

            var teamWithoutMembers = listOfTeams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamNeam)
                .ToList();

            foreach (var team in teamWithMembers)
            {
                team.Members.Sort();
                Console.WriteLine(team.TeamNeam);
                Console.WriteLine("- " + team.Creator);
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => $"-- {x}")));
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamWithoutMembers)
            {
                Console.WriteLine(team.TeamNeam);
            }
        }
    }
}
