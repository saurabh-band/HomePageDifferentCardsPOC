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
		var borders = sender as Border;
		borders.Shadow = new Shadow { Brush = Colors.Transparent };
		await borders.ScaleTo(0.95, 75, Easing.BounceOut);
		await borders.ScaleTo(1.0, 75, Easing.BounceIn);
		borders.Shadow = new Shadow { Brush = Color.FromHex("#570099") , Offset = new Point(0,15), Opacity = (float)0.15 };
	}

    private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
		var borders = sender as Border;
		borders.Shadow = new Shadow { Brush = Colors.Transparent };
		await borders.ScaleTo(0.95, 75, Easing.BounceOut);
		await borders.ScaleTo(1.0, 75, Easing.BounceIn);
		borders.Shadow = new Shadow { Brush = Color.FromHex("#570099"), Offset = new Point(0, 15), Opacity = (float)0.15 };

	}
}
//Brush="#570099"
//                        Offset="0,15"
//                        Radius="5" 
//                        Opacity="0.15"