namespace KokoObjectGui.GuiItems.Interfaces;

public interface IParentable {
	public List<IGuiItem> ChildElements { get; set; }
	public void AddChild(IGuiItem child);
	public void AddChildAtPosition(int position, IGuiItem child);
	public void RemoveChild(IGuiItem child);
	public void RemoveChild(uint index);
}