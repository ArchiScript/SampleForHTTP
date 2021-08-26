using System;
using SampleForHTTP.Services;
using SampleForHTTP.Modules;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace SampleForHTTP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string token = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjoi0JHQv" +
                "tCz0LTQsNC9IiwidGVuYW50IjoiNzI5IiwibmJmIjoxNjI5OTk0MTcxLCJleHAiOjE2" +
                "MzAwODA1NzEsImlzcyI6IlRlc3QtQmFja2VuZC0xIiwiYXVkIjoiQmFza2V0QmFsbENsd" +
                "WJTYW1wbGUifQ.bajWd2_y9qFbWLsGrAAQayxg2GPbg-USKUVKLhGYOyU";
            TeamService teamService = new TeamService(token);
            PlayerService playerService = new PlayerService(token);
            Team team = new Team()

            {
                Id = 123,
                Name = "Arsenal",
                FoundationYear = 2009,
                Conference = "A",
                Division = "d",
                ImageUrl = "dfkj"

            };
            await teamService.Add(team);
            await teamService.GetTeams();


            Player player = new Player()
            {
                Name = "Archi",
                Number = 4,
                Position = "Forward",
                Team = 649,
                Birthday = new DateTime(1985, 5, 6),
                Heigth = 190,
                Weigth = 90,
                AvatarUrl = "fjwlefjURL",
                Id = 9,
                TeamName = "Arsenal"

            };
            await playerService.Add(player);
            await playerService.GetPlayers();
        }
    }
}
