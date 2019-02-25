using System;

namespace WindowsFormsApplication1
{
	internal class Børnetid
	{
		private Afmagt def;

		public Børnetid(Afmagt def)
		{
			this.def = def;
		}

		internal void lightly(string p)
		{
			throw new NotImplementedException();
		}

		internal void bolMe(int p)
		{
			def.afMagt(p + 4).lineUpSi((double)p * Math.Sin(p), (double)p * Math.Sin(p + 30));
		}
	}
}
