using UnityEngine;
using System;

namespace BeatThat.ColorExtensions
{
	/// <summary>
	/// ext functions for Unity Color
	/// </summary>
	public static class ColorExt
	{
		public static Color WithAlpha(this Color c, float a)
		{
			return new Color(c.r, c.g, c.b, a);
		}

		public static string ToHex(this Color c)
		{
			using (var a = ArrayPool<byte>.Get (4)) {
				a.array [0] = (byte)(c.r * 255);
				a.array [1] = (byte)(c.g * 255);
				a.array [2] = (byte)(c.b * 255);
				a.array [3] = (byte)(c.a * 255);
				return BitConverter.ToString (a.array).Replace("-", "");
			}
		}

	}
}
