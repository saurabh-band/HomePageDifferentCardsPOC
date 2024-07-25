using CoreAnimation;
using CoreGraphics;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace HomePageDifferentCardsPOC
{
	public class CustomButtonHandler : ViewHandler<CustomButton, UIView>
	{
		public CustomButtonHandler(IPropertyMapper mapper, CommandMapper? commandMapper = null) : base(mapper, commandMapper)
		{
		}

		protected override UIView CreatePlatformView()
		{
			return new UIView();
		}
		protected override void ConnectHandler(UIView platformView)
		{
			base.ConnectHandler(platformView);
			UpdateBackground(platformView);
		}
		private void UpdateBackground(UIView platformView)
		{
			var layer = platformView.Layer;
			var cornerRadius = VirtualView.CornerRadius;
			layer.BackgroundColor = VirtualView.BackgroundColor.ToCGColor();
			layer.CornerRadius = cornerRadius;
			layer.MaskedCorners = CACornerMask.MinXMinYCorner | CACornerMask.MaxXMinYCorner; // Top left and top right corners
			layer.BorderColor = VirtualView.BackgroundColor.ToCGColor();
			layer.BorderWidth = 1;
			layer.ShadowColor = VirtualView.HasShadow ? UIColor.Black.CGColor : UIColor.Clear.CGColor;
			layer.ShadowOpacity = VirtualView.HasShadow ? 0.5f : 0f;
			layer.ShadowRadius = VirtualView.HasShadow ? 5 : 0;
			layer.ShadowOffset = new CGSize(0, 0);
			layer.MasksToBounds = false;
		}
		protected override void DisconnectHandler(UIView platformView)
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
