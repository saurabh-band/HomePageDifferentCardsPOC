namespace HomePageDifferentCardsPOC.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		//var border = sender as Border;
		//border.Shadow.Brush = Colors.White;
		//border.Background = Colors.White;
		//border.Shadow = new Shadow { Brush = Colors.Red, Offset = new Point(0,15), Opacity = (float)0.8 };
		var border = sender as Border;
		await border.ScaleTo(0.9, 75, Easing.BounceOut);
		await border.ScaleTo(1.0, 75, Easing.BounceIn);
	}

    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
		var border = sender as Border;
		await border.ScaleTo(0.9, 75, Easing.BounceOut);
		await border.ScaleTo(1.0, 75, Easing.BounceIn);
		
	}
}