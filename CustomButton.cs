using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace HomePageDifferentCardsPOC
{
	public class CustomButton : ContentView
	{
		public static readonly BindableProperty ImageSourceProperty =
			BindableProperty.Create(nameof(ImageSource), typeof(ImageSource), typeof(CustomButton));
		public static readonly BindableProperty TitleProperty =
			BindableProperty.Create(nameof(Title), typeof(string), typeof(CustomButton));
		public static readonly BindableProperty SubtitleProperty =
			BindableProperty.Create(nameof(Subtitle), typeof(string), typeof(CustomButton));
		public static readonly BindableProperty CommandProperty =
			BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(CustomButton));
		public static readonly BindableProperty BackgroundColorProperty =
			BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(CustomButton), Colors.Transparent);
		public static readonly BindableProperty CornerRadiusProperty =
			BindableProperty.Create(nameof(CornerRadius), typeof(float), typeof(CustomButton), 10f);
		public static readonly BindableProperty HasShadowProperty =
			BindableProperty.Create(nameof(HasShadow), typeof(bool), typeof(CustomButton), true);
		public ImageSource ImageSource
		{
			get => (ImageSource)GetValue(ImageSourceProperty);
			set => SetValue(ImageSourceProperty, value);
		}
		public string Title
		{
			get => (string)GetValue(TitleProperty);
			set => SetValue(TitleProperty, value);
		}
		public string Subtitle
		{
			get => (string)GetValue(SubtitleProperty);
			set => SetValue(SubtitleProperty, value);
		}
		public ICommand Command
		{
			get => (ICommand)GetValue(CommandProperty);
			set => SetValue(CommandProperty, value);
		}
		public new Color BackgroundColor
		{
			get => (Color)GetValue(BackgroundColorProperty);
			set => SetValue(BackgroundColorProperty, value);
		}
		public float CornerRadius
		{
			get => (float)GetValue(CornerRadiusProperty);
			set => SetValue(CornerRadiusProperty, value);
		}
		public bool HasShadow
		{
			get => (bool)GetValue(HasShadowProperty);
			set => SetValue(HasShadowProperty, value);
		}
		public CustomButton()
		{
			var image = new Image();
			image.SetBinding(Image.SourceProperty, new Binding(nameof(ImageSource), source: this));
			var titleLabel = new Label
			{
				FontAttributes = FontAttributes.Bold
			};
			titleLabel.SetBinding(Label.TextProperty, new Binding(nameof(Title), source: this));
			var subtitleLabel = new Label();
			subtitleLabel.SetBinding(Label.TextProperty, new Binding(nameof(Subtitle), source: this));
			var layout = new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				Children = { image, titleLabel, subtitleLabel }
			};
			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, new Binding(nameof(Command), source: this));
			layout.GestureRecognizers.Add(tapGestureRecognizer);
			Content = layout;
		}
	}
}
