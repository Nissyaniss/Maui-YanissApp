using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using YanissApp.Models;
using YanissApp.Views;

namespace YanissApp.ViewModels
{
    public class JokeListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "") 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private ObservableCollection<Jokes> _jokes = new();
        public ObservableCollection<Jokes> Jokes
        {
            get => _jokes;
            set { _jokes = value; OnPropertyChanged(); }
        }

        public ICommand LoadJokesCommand { get; }
        public ICommand JokeSelectedCommand { get; }

        private readonly IJokeService _jokeService;

        private Jokes _selectedItem;
        public Jokes SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddNewCoffeeCommand { get; }
        
        public JokeListViewModel(IJokeService jokeService)
        {
            _jokeService = jokeService;
            LoadJokesCommand = new Command(async () => await LoadJokes());
            JokeSelectedCommand = new Command(async () => await OnJokeSelected());
            AddNewCoffeeCommand = new Command(async () => await Shell.Current.GoToAsync(nameof(AddPage)));

            Task.Run(LoadJokes);
        }

        private async Task LoadJokes()
        {
            var jokes = await _jokeService.GetJokesAsync();
            Jokes = new ObservableCollection<Jokes>(jokes);
        }

        private async Task OnJokeSelected()
        {
            try
            {
                if (SelectedItem == null)
                {
                    return;
                }
                
                await Shell.Current.GoToAsync(
                    $"{nameof(JokeDetailPage)}",
                    true,
                    new Dictionary<string, object>
                    {
                        { "Joke", SelectedItem }
                    });
                SelectedItem = null; 
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[ERREUR] Erreur : {ex.Message}");
            }
        }
    }
}