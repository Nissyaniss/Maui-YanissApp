using System.Text.Json;
using YanissApp.Models;

namespace YanissApp.Services
{
    public class JokeService : IJokeService
    {
        private readonly HttpClient _httpClient = new();
        
        private readonly List<Jokes> _localJokes = new(); 

        public async Task AddJokeAsync(Jokes jokes)
        {
            _localJokes.Add(jokes);
            await Task.CompletedTask;
        }
        public async Task<List<Jokes>> GetJokesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://official-joke-api.appspot.com/random_ten");
                var json = await response.Content.ReadAsStringAsync();
                var coffees = JsonSerializer.Deserialize<List<Jokes>>(json);

                if (coffees != null)
                    coffees.AddRange(_localJokes); 
                return coffees ?? new List<Jokes>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur API : {ex.Message}");
                return new List<Jokes>(_localJokes);
            }
        }
    }
    
}