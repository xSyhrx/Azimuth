using System.Numerics;
namespace Azimuth.GameObjects
{
	public class GameObject
	{

		public Vector2 position;
		
		public virtual void load() { }
		public virtual void Draw() { }

		public virtual void Update(float _deltaTime) { }

		public virtual void Unload() { }
	}
}