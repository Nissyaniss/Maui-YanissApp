using YanissApp.ViewModels;

namespace YanissApp.Views
{
    public partial class ListPage : ContentPage
    {
        public ListPage(JokeListViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}