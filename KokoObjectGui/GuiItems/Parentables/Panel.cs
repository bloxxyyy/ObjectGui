using KokoObjectGui.GuiItems.Interfaces;
using KokoObjectGui.Helpers;

namespace KokoObjectGui.GuiItems.Parentables;
public class Panel : AParentElement, IGuiItem, IParentable, IRectable {
	public uint X { get; set; }
	public uint Y { get; set; }
	public uint Width { get; set; }
	public uint Height { get; set; }
	public Action<Rectangle> Draw { get; set; }

	public Panel(uint x, uint y, uint width, uint height) {
		X = x;
		Y = y;
		Width = width;
		Height = height;
	}

	public override void UpdateChildRectangles() => PanelRectangle.UpdateRectangleForPanel(new Rectangle(X, Y, Width, Height), ChildElements);

	public void UpdateRectangle(Rectangle containerData) {
		X = containerData.X;
		Y = containerData.Y;
		Width = containerData.Width;
		Height = containerData.Height;
	}
}
