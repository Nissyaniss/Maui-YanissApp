using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using YanissApp.Models;
using YanissApp.Services;

namespace YanissApp.ViewModels
{
    public class AddJokeViewModel : INotifyPropertyChanged
    {
        private string _type;
        private string _setup;
        private string _punchline;

        public string Type
        {
            get => _type;
            set { _type = value; OnPropertyChanged(); }
        }

        public string Setup
        {
            get => _setup;
            set { _setup = value; OnPropertyChanged(); }
        }
        
        public string Punchline
        {
            get => _punchline;
            set { _punchline = value; OnPropertyChanged(); }
        }

        public ICommand AddCommand { get; }

        private readonly IJokeService _jokeService;

        public AddJokeViewModel()
        {
            _jokeService = new JokeService();
            AddCommand = new Command(async () => await AddJokeAsync());
        }

        public async Task AddJokeAsync()
        {
            var joke = new Jokes
            {
                Type = Type,
                Setup = Setup,
                Punchline = Punchline,
            };

            await _jokeService.AddJokeAsync(joke);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}