using System.Windows.Input;

namespace HomePageDifferentCardsPOC.Views;

public partial class CompanyPage : ContentPage
{
	public CompanyPage()
	{
		InitializeComponent();
		BindingContext = new CompanyPageViewModel();
	}
	 public class CompanyPageViewModel
	{
		public ICommand YourCommand { get; }

		public CompanyPageViewModel()
		{
			YourCommand = new Command(OnButtonClicked);
		}
		private void OnButtonClicked()
		{
			// Handle the button click
		}
	}
}