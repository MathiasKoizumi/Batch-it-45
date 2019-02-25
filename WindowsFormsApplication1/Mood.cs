using System;
using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class Mood
	{
		private Color currentMood;

		public Color getMood()
		{
			return currentMood;
		}

		public Juklas affectMood(int damn, Juklas food)
		{
			currentMood = Color.FromArgb(200, 240, 180, 240);
			if (currentMood.GetBrightness() == 0f)
			{
				currentMood = Color.White;
			}
			return food;
		}

		internal Mood roundUp()
		{
			currentMood = Color.FromArgb(currentMood.ToArgb() + 200);
			return this;
		}

		internal Mood affectMood(int p)
		{
			throw new NotImplementedException();
		}
	}
}
