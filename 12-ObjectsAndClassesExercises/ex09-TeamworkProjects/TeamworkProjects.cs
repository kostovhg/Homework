using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }

    class TeamworkProjectsv10
    {
        public static void Main()
        {
            var listOfTeams = CreateTeams(int.Parse(Console.ReadLine()));

            FillTeamsWithMembers(listOfTeams);

            Console.WriteLine();
        }

        private static void FillTeamsWithMembers(List<Team> listOfTeams)
        {
            string input = Console.ReadLine();

            while(!input.Equals("end of assignment"))
            {
                string memberName = input.Split('-')[0];
                string teamName = input.Split('>')[1];

                // check if the team exist
                if (listOfTeams.All(t => t.Name != teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    input = Console.ReadLine(); continue;
                }

                // check if such member already exist in other team
                if (listOfTeams.Any(t => t.Members.Contains(memberName)) || listOfTeams.Any(t => t.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    input = Console.ReadLine(); continue;
                }
                listOfTeams.First(x => x.Name == teamName).Members.Add(memberName);

            }
        }

        private static List<Team> CreateTeams(int teamsCount)
        {
            var teamList = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string input = Console.ReadLine();
                string teamName = input.Split('-')[1];
                string creatorName = input.Split('-')[0];

                // Check if the current team exist
                if (teamList.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                // check if the creator have already a team
                else if (teamList.Any(x => x.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                 teamList.Add(new Team() { Name = teamName, Creator = creatorName, Members= new List<string>() });

                
            }

            return teamList;
        }
    }
}