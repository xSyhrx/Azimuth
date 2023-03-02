using Raylib_cs;
namespace Spastroids.Ui
{
	public struct ColorBlock
	{
		public Color normal;
		public Color hovered;
		public Color pressed;
		public Color disabled;
		
		public ColorBlock(Color _normal, Color _hovered, Color _pressed, Color _disabled)
		{
			normal = _normal;
			hovered = _hovered;
			pressed = _pressed;
			disabled = _disabled;
		}
	}
}