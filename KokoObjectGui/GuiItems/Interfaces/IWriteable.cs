using KokoObjectGui.Helpers;

namespace KokoObjectGui.GuiItems.Interfaces;

public interface IWriteable : IRectable, IGuiItem {
	public string Text { get; set; }
	public Color TextColor { get; set; }
	public Action<Rectangle, Writable> Draw { get; set; }
}