using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SampleForHTTP.Modules;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SampleForHTTP.Services
{
    class TeamService
    {
        private readonly string _token;

        public TeamService(string token)
        {
            _token = token ?? throw new ArgumentNullException(nameof(token));
        }

        public async Task Add(Team team)
        {
            string serializedTeam = JsonConvert.SerializeObject(team);
            var content = new StringContent(serializedTeam, Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(_token);

                await client.PostAsync("http://dev.trainee.dex-it.ru/api/Team/Add", content);

            }

        }

        public async Task<TeamResponse> GetTeams()
        {
            HttpResponseMessage responseMessage;
            TeamResponse teamResponse;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = 
                    AuthenticationHeaderValue.Parse(_token);
                responseMessage = await client.GetAsync("http://dev.trainee.dex-it.ru/api/Team/GetTeams");
                
                responseMessage.EnsureSuccessStatusCode();

                string serialzeMessage = await responseMessage.Content.ReadAsStringAsync();
                teamResponse = JsonConvert.DeserializeObject<TeamResponse>(serialzeMessage);

            }
            return teamResponse;
        }
    }
}
