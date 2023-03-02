using Azimuth;
using Azimuth.GameStates;

using Raylib_cs;

using Spastroids.GameStates;

namespace Spastroids
{
	public class SpastroidsGame : Game
	{
		public override void Load()
		{
			Raylib.InitAudioDevice();
			
			GameStateManager.AddGameState(new  MainMenuState());
			GameStateManager.AddGameState(new PlayState());
			
			GameStateManager.ActivateState("Main Menu");
		}

		public override void Unload()
		{
			Raylib.CloseAudioDevice();
		}
	}
}