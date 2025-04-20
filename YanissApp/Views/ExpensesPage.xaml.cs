using System.Collections.ObjectModel;
using YanissApp.Models;
using YanissApp.ViewModels;

namespace YanissApp.Views
{
    public partial class ExpensesPage : ContentPage
    {
        private ObservableCollection<Expense> _expenses = new ObservableCollection<Expense>();
        private double _total;

        public ExpensesPage()
        {
            InitializeComponent();
            ExpensesListView.ItemsSource = _expenses;
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
        
            ExpensesListView.ItemsSource ??= _expenses;
        
            UpdateTotal();
        }
        
        private void UpdateTotal()
        {
            _total = _expenses.Sum(e => e.Amount);
            TotalLabel.Text = $"Total: {_total:C2}";
        }

        private void OnAddExpenseClicked(object sender, EventArgs e)
        {
            if (double.TryParse(ExpenseAmountEntry.Text, out double amount))
            {
                _expenses.Add(new Expense
                {
                    Name = ExpenseNameEntry.Text,
                    Amount = amount
                });
                _total += amount;
                TotalLabel.Text = $"Total: {_total:C2}";
                ExpenseNameEntry.Text = "";
                ExpenseAmountEntry.Text = "";
            }
        }
    }
}

