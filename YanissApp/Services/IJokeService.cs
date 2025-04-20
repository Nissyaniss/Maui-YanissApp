using YanissApp.Models;

public interface IJokeService
{
    Task<List<Jokes>> GetJokesAsync();
    Task AddJokeAsync(Jokes jokes);
}