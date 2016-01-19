using System;
using UIKit;

namespace ThinkOut.iPhone
{
	public static class UIColorExtensions
	{
		public static UIColor FromHex(int hexValue)
		{
			return UIColor.FromRGB(
				(((float)((hexValue & 0xFF0000) >> 16)) / 255.0f),
				(((float)((hexValue & 0xFF00) >> 8)) / 255.0f),
				(((float)(hexValue & 0xFF)) / 255.0f)
			);
		}
	}
}

