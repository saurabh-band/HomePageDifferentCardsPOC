namespace HomePageDifferentCardsPOC.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	//Home Page Button Card Tapped animation

	private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		var borders = sender as Border;

		//Tap-In
		borders.Shadow = new Shadow { Brush = Colors.Transparent };
		borders.BackgroundColor = Color.FromHex("#EDEFF2");

		await Task.Delay(150);

		//Tap-Out
		borders.Shadow = new Shadow { Brush = Color.FromHex("#570099"), Opacity = (float)0.15 };
		borders.Shadow.Offset = DeviceInfo.Platform == DevicePlatform.Android? new Point(0,15):new Point(0,8);
		borders.BackgroundColor = Color.FromHex("#F6F7F8");

	}

	private async void TapGestureRecognizer_Tapped_Plus(object sender, TappedEventArgs e)
    {
		var borders = sender as Border;
		//Tap-In
		borders.Shadow = new Shadow { Brush = Colors.Transparent };
		borders.Background = new LinearGradientBrush(
			new GradientStopCollection
			{
				new GradientStop(Color.FromHex("#DCB3FB"),0),
				new GradientStop(Color.FromHex("#FFBBFF"),(float)0.6)
			},
			new Point(1, 0),
			new Point(0, 1)
		);

		await Task.Delay(150);

		//Tap Out
		borders.Shadow = new Shadow { Brush = Color.FromHex("#570099"), Opacity = (float)0.15 };
		borders.Shadow.Offset = DeviceInfo.Platform == DevicePlatform.Android ? new Point(0, 15) : new Point(0, 8);

		borders.Background = new LinearGradientBrush(
			new GradientStopCollection
			{
				new GradientStop(Color.FromHex("#e7ccfc"),0),
				new GradientStop(Color.FromHex("#f9dafa"),(float)0.6)
			},
			new Point(1, 0),
			new Point(0, 1)
		);

	}

}


//Brush="#570099" Offset="0,15" Radius="5" Opacity="0.15"
//var border = sender as Border;
//border.Shadow.Brush = Colors.White;
//border.Background = Colors.White;
//border.Shadow = new Shadow { Brush = Colors.Red, Offset = new Point(0,15), Opacity = (float)0.8 };
//await borders.ScaleTo(1.0, 75, Easing.BounceOut);
//await borders.ScaleTo(1.0, 75, Easing.BounceIn);
