using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpotifyTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SpotifyTest.Services
{
    public class SpotifyService
    {
        HttpClient _client;
        public SpotifyService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.spotify.com/v1/");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "BQDcHt3dR_3z3h-iF6ChCr5rWqC1fdxGdvCxI3fezPGx7pKjMJGB5dwgPuF-Fx2plJyK264a38OruHUESx0");
        }

        public async Task<SearchResult> GetEminemAlbums()
        {
            var response = await _client.GetAsync("search?q=eminem&type=album");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var items = JsonConvert.DeserializeObject<SearchResult>(responseString);
                return items;
            }

            return null;
        }
    }
}
