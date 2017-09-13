using UnityEngine;

namespace BeatThat
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

	}
}
