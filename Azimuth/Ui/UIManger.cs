﻿using Raylib_cs;

namespace Azimuth.Ui
{
	// ReSharper disable once InconsistentNaming
	public static class UIManger
	{
		private static List<Widget> widgets = new List<Widget>();

		public static void Add(Widget _widget)
		{
			if(!widgets.Contains(_widget))
				widgets.Add(_widget);
		}

		public static void Remove(Widget _widget)
		{
			if(widgets.Contains(_widget))
				widgets.Remove(_widget);
		}

		internal static void Update()
		{
			widgets.Sort();
			
			foreach(Widget widget in widgets)
				widget.Update(Raylib.GetMousePosition());
		}

		internal static void Draw()
		{
			foreach(Widget widget in widgets)
			{
				widget.Draw();
			}
		}
	}
}