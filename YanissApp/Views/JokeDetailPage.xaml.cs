using YanissApp.Models;
using YanissApp.ViewModels;

namespace YanissApp.Views
{
    public partial class JokeDetailPage : ContentPage, IQueryAttributable
    {
        public JokeDetailPage()
        {
            InitializeComponent();
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.TryGetValue("Joke", out var coffeeObj) && coffeeObj is Jokes coffee)
                BindingContext = new JokeDetailViewModel(coffee);
        }
    }
}