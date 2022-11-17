using KokoObjectGui.GuiItems.Interfaces;
using KokoObjectGui.Helpers;

namespace KokoObjectGui.GuiItems.Basic;
public class Label : IGuiItem, IRectable, IWriteable {
	public uint X { get; set; }
	public uint Y { get; set; }
	public uint Width { get; set; }
	public uint Height { get; set; }
	public string Text { get; set; }
	public Color TextColor { get; set; }
	Action<Rectangle> IRectable.Draw { get; set; }
	Action<Rectangle, Writable> IWriteable.Draw { get; set; }

	public Label(string text, uint x, uint y, uint width, uint height, Color textColor) {
		Text = text;
		X = x;
		Y = y;
		Width = width;
		Height = height;
		TextColor = textColor;
	}

	public void UpdateRectangle(Rectangle containerData) {
		X = containerData.X;
		Y = containerData.Y;
		Width = containerData.Width;
		Height = containerData.Height;
	}
}
