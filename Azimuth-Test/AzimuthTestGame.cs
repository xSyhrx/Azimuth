using Azimuth;
using Azimuth.Ui;

using Raylib_cs;

using System.Numerics;

namespace Azimuth_Test
{
	public class AzimuthTestGame : Game
	{

		private Button button;

		private ImageWidget image;
		
		public override void Load()
		{
			button = new Button(Vector2.Zero, new Vector2(150, 75), Button.RenderSettings.normal);
			button.SetDrawLayer(100);
			image = new ImageWidget(Vector2.Zero, new Vector2(200, 400), "imageWidget");
			
			UIManger.Add(button);
			UIManger.Add(image);
			
		}
		
		public override void Unload()
		{
			
		}
	}
}