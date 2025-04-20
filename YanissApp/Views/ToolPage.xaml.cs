namespace YanissApp.Views;

public partial class ToolPage : ContentPage
{
    public ToolPage()
    {
        InitializeComponent();
    }
    private async void OnExpenseButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ExpensesPage));
    }
    
    private async void OnCitationButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CitationPage));
    }
}