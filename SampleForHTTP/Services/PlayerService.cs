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
    class PlayerService
    {
        private readonly string _token;

        public PlayerService(string token)
        {
            _token = token ?? throw new ArgumentNullException(nameof(token));
        }

        public async Task Add(Player player)
        {
            string serializedPlayer = JsonConvert.SerializeObject(player);
            var content = new StringContent(serializedPlayer, Encoding.UTF8, "application/json");
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(_token);
                var response = await client.PostAsync("http://dev.trainee.dex-it.ru/api/Player/Add", content);

            }

        }

        public async Task<PlayerRepsonse> GetPlayers()
        {
            HttpResponseMessage responseMessage;
            PlayerRepsonse playerResponse;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    AuthenticationHeaderValue.Parse(_token);
                responseMessage = await client.GetAsync("http://dev.trainee.dex-it.ru/api/Player/GetPlayers");

                responseMessage.EnsureSuccessStatusCode();

                string serialzeMessage = await responseMessage.Content.ReadAsStringAsync();
                playerResponse = JsonConvert.DeserializeObject<PlayerRepsonse>(serialzeMessage);

            }
            return playerResponse;
        }
    }
}
