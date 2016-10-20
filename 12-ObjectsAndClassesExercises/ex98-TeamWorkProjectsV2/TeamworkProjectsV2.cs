using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex89_TeamworkProjectsV2
{
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public void AddMember(string name)
        {
            if (Members == null)
            {
                Members.Add("");
            }
            else
            {
                Members.Add(name);
                Members.Remove("");
            }
        }

    }

    class TeamworkProjectsv2
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            // collect teams and their authors
            var teamsList = CollectInputsForNewTeams(numberOfTeams);

            string input = Console.ReadLine();

            AddMembersToTeams(teamsList, input);
            teamsList.OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name);

            PrintTeams(teamsList);
        }

        private static void PrintTeams(List<Team> teamsList)
        {
            foreach (Team t in teamsList
                .Where(x=> x.Members != null)
                .OrderByDescending(x => x.Members.Count())
                .ThenBy(t => t.Name))
            {
                Console.WriteLine(t.Name);
                Console.WriteLine($"- {t.Creator}");
                foreach (var member in t.Members.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            //if (teamsList.Any(x => x.Members == null))
            //{
                Console.WriteLine("Teams to disband:");
                foreach (Team t in teamsList.Where(x => x.Members == null))
                {
                    Console.WriteLine($"{t.Name}");
                }

            //}

        }

        private static void AddMembersToTeams(List<Team> teamsList, string input)
        {
            while (!input.Equals("end of assignment"))
            {
                string[] inputData = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string inputMemberName = inputData[0];
                string inputApplyForTeam = inputData[1];

                // check if there is such team to apply for
                if (!teamsList.Any(x => x.Name == inputApplyForTeam))
                {
                    Console.WriteLine($"Team {inputApplyForTeam} does not exist!");
                }
                // check if the Creator of the team is try to be a member in it
                else if (teamsList.Any(x => x.Creator == inputMemberName))
                {
                    Console.WriteLine($"Member {inputMemberName} cannot join team {inputApplyForTeam}!");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    if (teamsList.Last(x => x.Name == inputApplyForTeam).Members == null)
                    {
                        List<string> members = new List<string>();
                        members.Add(inputMemberName);
                        teamsList.Last(x => x.Name == inputApplyForTeam).Members = members;
                        
                    }
                    else
                    {
                        teamsList.Last(x => x.Name == inputApplyForTeam).Members.Add(inputMemberName);
                    }

                }



                input = Console.ReadLine();
            }

            return;
        }

        private static List<Team> CollectInputsForNewTeams(int n)
        {
            List<Team> teamsList = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputData = input.Split('-');
                string inputCreatorName = inputData[0];
                string inputTeamName = inputData[1];

                Team inputTeam = new Team();
                inputTeam.Name = inputTeamName;
                inputTeam.Creator = inputCreatorName;

                if (teamsList.Any(c => c.Creator == inputCreatorName))
                {
                    Console.WriteLine($"{inputCreatorName} cannot create another team!");
                    continue;
                }
                else if (teamsList.Any(t => t.Name == inputTeamName))
                {
                    Console.WriteLine($"Team {inputTeamName} was already created!");
                    continue;
                }
                else
                {
                    teamsList.Add(inputTeam);
                    Console.WriteLine($"Team {inputTeamName} has been created by {inputCreatorName}!");
                }

            }
            return teamsList;
        }
    }

}

