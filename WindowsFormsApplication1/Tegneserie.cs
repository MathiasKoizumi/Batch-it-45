using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class Tegneserie
	{
		private Lingo børnemuseum;

		private Jingo juklas;

		private JoyRomeo jongo;

		private string s;

		private Random k = new Random();

		public Tegneserie(JoyRomeo romeo)
		{
			børnemuseum = new Lingo();
			juklas = romeo.partyTime();
			jongo = romeo;
		}

		public Tegneserie(string s)
		{
			this.s = s;
		}

		internal IEnumerable<Mood> farvedeFolk()
		{
			yield return new Mood().affectMood(k.Next(300));
			yield return new Mood().affectMood(k.Next(300));
			yield return new Mood().affectMood(k.Next(200));
			yield return new Mood().affectMood(k.Next(300));
			yield return new Mood().affectMood(k.Next(400));
			yield return new Mood().affectMood(k.Next(300));
			yield return new Mood().affectMood(k.Next(100));
			yield return new Mood().affectMood(k.Next(300));
			yield return new Mood().affectMood(k.Next(300));
			yield return new Mood().affectMood(k.Next(2000));
			throw new NotImplementedException();
		}

		internal void lineUpSi(double p, double p_2)
		{
			throw new NotImplementedException();
		}
	}
}
