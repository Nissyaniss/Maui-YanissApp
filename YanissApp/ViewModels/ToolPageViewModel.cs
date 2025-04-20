using System.Windows.Input;
using System.Diagnostics;
using YanissApp.Views;

namespace YanissApp.ViewModels
{
    public class ToolPageViewModel
    {
        public ICommand NavigateToWorkPeriodCommand { get; }

        public ToolPageViewModel()
        {
            NavigateToWorkPeriodCommand = new Command(async () => await NavigateToExpensesPage());
        }

        private async Task NavigateToExpensesPage()
        {
            await Shell.Current.GoToAsync(nameof(ExpensesPage));
        }
    }
}