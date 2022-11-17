using KokoObjectGui.Helpers;

namespace KokoObjectGui.GuiItems.Interfaces;

/// <summary>
/// You never set an X or Y position because it is set by the parent.
/// </summary>
public interface IRectable : IGuiItem {
	public uint X { get; set; }
	public uint Y { get; set; }
	public uint Width { get; set; }
	public uint Height { get; set; }

	public Action<Rectangle> Draw { get; set; }
	public void UpdateRectangle(Rectangle containerData);
}