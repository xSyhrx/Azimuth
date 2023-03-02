using Azimuth;
using Raylib_cs;
namespace Spastroids
{
	public static class Program
	{

		public const int WINDOW_HEIGHT = 800;
		public const int WINDOW_WIDTH = 800;
		public const string TITLE = "Spastroids";
		public static readonly Color Background = Color.BLACK;
		
		
		public static void Main()
		{
			Application.Run(WINDOW_WIDTH, WINDOW_HEIGHT, TITLE,Background, new SpastroidsGame());
		}
	}
}