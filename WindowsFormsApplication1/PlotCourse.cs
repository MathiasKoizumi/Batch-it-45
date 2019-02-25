namespace WindowsFormsApplication1
{
	internal class PlotCourse
	{
		public PlotCourse(Jango s)
		{
		}

		internal Movement typeHente()
		{
			return new Movement();
		}

		internal double getYouX(int waypointNumber)
		{
			return waypointNumber * 5;
		}

		internal double getYouY(int waypointNumber)
		{
			return waypointNumber * 200;
		}
	}
}
