using YanissApp.Models;

namespace YanissApp.ViewModels
{
    public class JokeDetailViewModel
    {
        public Jokes Jokes { get; }

        public JokeDetailViewModel(Jokes jokes)
        {
            Jokes = jokes ?? throw new ArgumentNullException(nameof(jokes));
        }
    }
}