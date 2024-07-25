using Android.Content;
using Android.Graphics.Drawables;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePageDifferentCardsPOC
{
	public class CustomButtonHandler : ViewHandler<CustomButton, ContentViewGroup>
	{
		public CustomButtonHandler(IPropertyMapper mapper, CommandMapper? commandMapper = null) : base(mapper, commandMapper)
		{
		}

		//public CustomButtonHandler(): base()
		//{ }	

		protected override ContentViewGroup CreatePlatformView()
		{
			var contentViewGroup = new ContentViewGroup(Context);
			return contentViewGroup;
		}
		protected override void ConnectHandler(ContentViewGroup platformView)
		{
			base.ConnectHandler(platformView);
			UpdateBackground(platformView);
		}
		private void UpdateBackground(ContentViewGroup platformView)
		{
			var backgroundDrawable = new GradientDrawable();
			backgroundDrawable.SetColor(VirtualView.BackgroundColor.ToAndroid());
			float topLeftRadius = VirtualView.CornerRadius;
			float topRightRadius = VirtualView.CornerRadius;
			float bottomRightRadius = 0;
			float bottomLeftRadius = 0;
			backgroundDrawable.SetCornerRadii(new float[] {
			   topLeftRadius, topLeftRadius,
			   topRightRadius, topRightRadius,
			   bottomRightRadius, bottomRightRadius,
			   bottomLeftRadius, bottomLeftRadius
		   });
			platformView.SetBackground(backgroundDrawable);
		}
		protected override void DisconnectHandler(ContentViewGroup platformView)
		{
			base.DisconnectHandler(platformView);
		}
		public static void MapBackground(CustomButtonHandler handler, CustomButton customButton)
		{
			handler.UpdateBackground(handler.PlatformView);
		}
		public static void MapCornerRadius(CustomButtonHandler handler, CustomButton customButton)
		{
			handler.UpdateBackground(handler.PlatformView);
		}
		public static void MapHasShadow(CustomButtonHandler handler, CustomButton customButton)
		{
			// Implement shadow if needed
		}
	}
}
