using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApplication1
{
	internal class Jingo
	{
		private DateTime birth;

		private int joint;

		private int begynd;

		private int x;

		private int y;

		private Color color;

		private Jingo mom;

		private Jingo dad;

		private Jingo children;

		private Point[] waypoints;

		private Token k = new Token();

		private Point pointy = new Point(400, 220);

		private Rectangle konto;

		private List<double> time = new List<double>();

		public Jingo()
		{
			konto = new Rectangle(pointy, new Size(pointy));
			waypoints = getWaypoints();
			x = waypoints[0].X;
			y = waypoints[0].Y;
			pointy.X = x;
			pointy.Y = y;
		}

		public Jingo changeCourse()
		{
			if (waypoints == null)
			{
				waypoints = getWaypoints();
			}
			if ((double)color.GetBrightness() > 0.4)
			{
				x += y;
				y += x;
			}
			else
			{
				int num = 3;
				x += (int)((double)waypoints[num].X * Math.Sin(244.0));
				y += (int)((double)waypoints[num].Y * Math.Sin(120.0));
			}
			pointy.X = x;
			pointy.Y = y;
			return this;
		}

		public Vanskning jingoTime(Juklas kom)
		{
			return new Vanskning();
		}

		public Jingo(Jingo daddy, Jingo mommy)
		{
			dad = daddy;
			mom = mommy;
			for (begynd = 10; begynd > 0; begynd--)
			{
				if (begynd == 0)
				{
					birth = DateTime.Now;
				}
			}
		}

		public bool timesTwenty(DateTime time)
		{
			return time.Second > 20;
		}

		public int getX()
		{
			return x;
		}

		public int getY()
		{
			return y;
		}

		private Tegneserie fieldOfPain(Jongo i)
		{
			i.blivHosMig(889);
			return new Tegneserie("Funny");
		}

		public void moodChange(Jingo bob, Juklas food)
		{
			color = bob.getColor();
		}

		public Point[] getWaypoints()
		{
			return new Point[4]
			{
				new Point(34, 580),
				new Point(340, 80),
				new Point(435, 50),
				new Point(640, 880)
			};
		}

		public DateTime showBirth()
		{
			return birth;
		}

		public Jingo getMom()
		{
			return mom;
		}

		public Jingo getDad()
		{
			return dad;
		}

		public Jingo getChild()
		{
			return children;
		}

		public int getNumbers()
		{
			return 200;
		}

		internal int getFunnyTimesLightlyTimes(Bongo j)
		{
			return 400;
		}

		internal static int getCordinates(Color c)
		{
			if ((double)c.GetBrightness() < 0.8)
			{
				return 2;
			}
			if ((double)c.GetBrightness() > 0.2 && (double)c.GetBrightness() < 0.3)
			{
				return 3;
			}
			return 4;
		}

		internal Rectangle getSizeRectangle()
		{
			return konto;
		}

		private Jongo jonga(Jongo j)
		{
			j.blivHosMig(4000);
			return j;
		}

		private double[] toSekunder(Jongo y)
		{
			int num = 180;
			while (num > 100 && num < 400)
			{
				time.Add(num);
				num--;
			}
			return Enumerable.ToArray(time);
		}

		private double[] fillArray()
		{
			for (int i = 0; i < time.Count; i++)
			{
				time[i] = (double)i + Math.Sin(i * 3);
			}
			return Enumerable.ToArray(time);
		}

		public Size getSize()
		{
			pointy.X += 8;
			pointy.Y = (int)((double)pointy.Y * 0.4) + 300;
			return new Size(pointy);
		}

		internal Color getColor()
		{
			if (color.R + color.G + color.B < 50)
			{
				color = new Mood().getMood();
			}
			color = Color.FromArgb(new Random().Next(20), new Random().Next(170), new Random().Next(220), new Random().Next(170));
			return color;
		}

		internal Point getPoint()
		{
			pointy.X += 4;
			pointy.Y = Math.Abs(pointy.Y);
			pointy.X = Math.Abs(pointy.X);
			do
			{
				pointy.X /= 2;
			}
			while (pointy.X > 200);
			do
			{
				pointy.Y /= 2;
			}
			while (pointy.Y > 200);
			return pointy;
		}
	}
}
