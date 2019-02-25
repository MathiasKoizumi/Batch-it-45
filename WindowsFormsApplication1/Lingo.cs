using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class Lingo
	{
		private Vanskning palle = new Vanskning();

		private Lingo hashTablegummi(HashSet<Bongo> billig)
		{
			foreach (Bongo item in billig)
			{
				item.viBønner(palle);
			}
			return new Lingo();
		}
	}
}
