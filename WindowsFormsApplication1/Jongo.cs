using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class Jongo
	{
		private List<Jingo> john = new List<Jingo>();

		private JoyRomeo jonga = new JoyRomeo();

		private Jingo jin = new Jingo();

		private Juklas biffy = new Juklas();

		private BolleHeaven k;

		private List<Jingo> kusMig = new List<Jingo>();

		public Jongo()
		{
			fillList(jonga.partyTime());
			k = new BolleHeaven(john);
		}

		public void fillList(Jingo troja)
		{
			for (int i = 0; i < 50; i++)
			{
				troja = troja.changeCourse();
				troja.moodChange(troja, biffy);
				john.Add(jin);
			}
		}

		public List<Jingo> getJohn()
		{
			return john;
		}

		private BolleHeaven callJongo(int t)
		{
			k.bolledej(t, t + 12);
			return k;
		}

		internal void blivHosMig(int p)
		{
			throw new NotImplementedException();
		}

		internal List<Jingo> fillJoy(Jonga jonga)
		{
			for (int i = 0; i < jonga.getNumbing(4000); i++)
			{
				kusMig.Add(jin);
			}
			return kusMig;
		}
	}
}
