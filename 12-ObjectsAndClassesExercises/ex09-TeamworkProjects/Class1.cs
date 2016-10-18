//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ex09_TeamworkProjects
//{
//    class Team
//    {
//        public string Name { get; set; }
//        public string Creator { get; set; }
//        public List<string> Members { get; set; }

//        public void AddMember(string name)
//        {
//            if (Members == null)
//            {
//                Members.Add("");
//            }
//            else
//            {
//                Members.Add(name);
//                Members.Remove("");
//            }
//        }

//    }

//    class TeamworkProjects
//    {
//        static void Main1(string[] args)
//        {
//            var teamsCount = int.Parse(Console.ReadLine());

//            List<Team> listOfTeams = new List<Team>();

//            for (int i = 0; i < teamsCount; i++)
//            {
//                string[] input = Console.ReadLine().Split('-');
//                if (listOfTeams.Any(x => x.Name.Equals(input[1])))
//                {
//                    Console.WriteLine($"Team {input[1]} was already created!");
//                    continue;
//                }

//                if (listOfTeams.Any(x => x.Creator.Equals(input[0])))
//                {
//                    Console.WriteLine($"{input[0]} cannot create another team!");
//                    continue;
//                }
//                else
//                {
//                    listOfTeams.Add(new Team { Name = input[1], Creator = input[0], Members = new List<string>() });
//                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
//                }
//            }

//            string inputLine = Console.ReadLine();

//            while (!inputLine.Equals("end of assignment"))
//            {
//                string[] input = inputLine.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
//                string memberName = input[0];
//                string applyToTeam = input[1];

//                if (listOfTeams.All(x => x.Name != applyToTeam))
//                {
//                    Console.WriteLine($"Team {applyToTeam} does not exist!");
//                    inputLine = Console.ReadLine();
//                    continue;
//                }
//                if (listOfTeams.Any(x => x.Members.Contains(memberName) || x.Creator == memberName))
//                {
//                    Console.WriteLine($"Member {memberName} cannot join team {applyToTeam}!");
//                    inputLine = Console.ReadLine();
//                    continue;
//                }

//                listOfTeams
//                    .Where(x => x.Name == applyToTeam)
//                    .Last()
//                    .Members.Add(memberName);

//                inputLine = Console.ReadLine();
//            }

//            foreach (var team in listOfTeams
//                .Where(t => t.Members.Count() > 0)
//                .OrderByDescending(c => c.Members.Count())
//                .ThenBy(n => n.Members))
//            {
//                Console.WriteLine($"{team.Name}");
//                Console.WriteLine($"- {team.Creator}");
//                foreach (var member in team.Members.OrderBy(x => x))
//                {
//                    Console.WriteLine($"-- {member}");
//                }
//            }

//            Console.WriteLine("Teams to disband:");
//            foreach (var team in listOfTeams.OrderBy(t => t.Name)
//                .Where(m => m.Members.Count() < 1))
//            {
//                Console.WriteLine($"{team.Name}");
//            }

//        }

//    }
//}

