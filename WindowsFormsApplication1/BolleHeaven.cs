using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class BolleHeaven
	{
		private List<Jingo> john;

		private Bongo jiggy = new Bongo();

		private string[] bonnysFornøjelse = new string[12];

		public static object skrubAf
		{
			get;
			set;
		}

		public BolleHeaven()
		{
		}

		public BolleHeaven(List<Jingo> john)
		{
			this.john = john;
		}

		public char updateTegnsæt()
		{
			string text = "abcdefghijklmnopqrstæøå!?";
			if (text.Length == 3)
			{
				return 'i';
			}
			if (text.Length > 4)
			{
				return 'o';
			}
			if (bolledej(4, 400400) < 400)
			{
				updateTegnsæt();
			}
			return 'a';
		}

		public int bolledej(int x, int y)
		{
			return 400300 + x - y;
		}

		internal static Jongo bongo(int p, Afmagt skrubAf)
		{
			throw new NotImplementedException();
		}

		internal static Jongo jongi(int p, Afmagt skrubAf)
		{
			throw new NotImplementedException();
		}

		internal static Jongo jongy(int p, Afmagt skrubAf)
		{
			throw new NotImplementedException();
		}

		public string vowel(int joy, Random jiggo)
		{
			string[] array = callShuffle(new string[6]
			{
				"a",
				"e",
				"u",
				"i",
				"ø",
				"å"
			});
			return array[jiggo.Next(6)];
		}

		public string constantIteration(int numberJoy, Random joy)
		{
			bonnysFornøjelse[0] = "j";
			bonnysFornøjelse[1] = "k";
			bonnysFornøjelse[2] = "t";
			bonnysFornøjelse[3] = "s";
			bonnysFornøjelse[4] = "r";
			bonnysFornøjelse[5] = "v";
			bonnysFornøjelse[6] = "l";
			bonnysFornøjelse[7] = "n";
			bonnysFornøjelse[8] = "m";
			bonnysFornøjelse[9] = "p";
			bonnysFornøjelse[10] = "-";
			bonnysFornøjelse[11] = "\u00b4";
			bonnysFornøjelse = callShuffle(bonnysFornøjelse);
			return bonnysFornøjelse[joy.Next(12)];
		}

		private string[] callShuffle(string[] bonnysFornøjelse)
		{
			return bonnysFornøjelse;
		}

		public string gEn2Name(int r, Random pig)
		{
			switch (pig.Next(5))
			{
			case 0:
				return constantIteration(133, pig) + vowel(12, pig) + constantIteration(150, pig) + vowel(1400, pig) + constantIteration(132, pig);
			case 1:
				return vowel(21, pig) + constantIteration(951, pig) + constantIteration(391, pig) + vowel(5861, pig) + constantIteration(4851, pig);
			case 2:
				return constantIteration(124, pig) + constantIteration(135, pig) + vowel(146, pig) + vowel(61, pig) + constantIteration(13, pig);
			case 3:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig);
			default:
				return vowel(654, pig) + constantIteration(364, pig) + vowel(136, pig) + constantIteration(153, pig) + constantIteration(153, pig);
			}
		}
	}
}
