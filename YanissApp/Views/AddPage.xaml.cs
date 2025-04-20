using YanissApp.ViewModels;

namespace YanissApp.Views
{
    public partial class AddPage : ContentPage
    {
        private readonly AddJokeViewModel _viewModel;

        public AddPage()
        {
            InitializeComponent();
            _viewModel = new AddJokeViewModel();
            BindingContext = _viewModel;
        }
        
        private async void OnAddJokeClicked(object sender, EventArgs e)
        {
            if (Type.Text == null || Setup.Text == null || Punchline.Text == null)
            {
                Error.IsVisible = true;
                return;
            }
            
            await _viewModel.AddJokeAsync();

            await Shell.Current.GoToAsync("ListPage");
        }
    }
}