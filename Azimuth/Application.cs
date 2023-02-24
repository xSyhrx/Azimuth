﻿using Azimuth.GameObjects;
using Azimuth.GameStates;

using Raylib_cs;
namespace Azimuth
{
	public sealed class Application
	{
		public  static  Application Instance { get; private set; }

		public static void Run(int _width, int _height, string _title, Color _color, Game _game)
		{
			Instance = new Application(_width, _height, _title,_color, _game);
			Instance.Run();
		}
		public Window Window { get; }

		private readonly Game game;
		public Application(int _width, int _height, string _name, Color _color, Game _game)
		{
			Window = new Window(_width, _height, _name, _color);
			Instance = this;
			game = _game;
		}
		
		private void Run()
		{
			Window.Open();
			Assets.Load();
			game.Load();
			
			while(!Raylib.WindowShouldClose())
			{
				float deltaTime = Raylib.GetFrameTime();
				GameObjectManager.Update(deltaTime);
				GameStateManager.Update(deltaTime);
				
				
				Raylib.BeginDrawing();
				Window.Clear();
				
				// Global Drawing here
				GameObjectManager.Draw();
				GameStateManager.Draw();
				Raylib.EndDrawing();
			}
			game.Unload();
			Assets.Unload();
			Window.Close();
		}
	}
}