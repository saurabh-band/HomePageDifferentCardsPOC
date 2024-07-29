using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HomePageDifferentCardsPOC.ViewModels
{
    public class HomePageViewModel
    {
		public ICommand ButtonCommand { private set; get; }




		public HomePageViewModel()
		{
			ButtonCommand = new Command(
				execute: () =>
				{
					RefreshCanExecutes();
				});
    }

		void RefreshCanExecutes()
		{

		}
	}
}
