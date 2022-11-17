using KokoObjectGui.GuiItems.Interfaces;

namespace KokoObjectGui.GuiItems.Parentables;

public abstract class AParentElement : IParentable {
	public List<IGuiItem> ChildElements { get; set; } = new();

	public void AddChild(IGuiItem child) {
		ChildElements.Add(child);
		UpdateChildRectangles();
	}

	public void AddChildAtPosition(int position, IGuiItem child) {
		ChildElements.Insert(position, child);
		UpdateChildRectangles();
	}

	public void RemoveChild(IGuiItem child) {
		ChildElements.Remove(child);
		UpdateChildRectangles();
	}

	public void RemoveChild(uint index) {
		var child = ChildElements.ElementAt((int)index);
		ChildElements.Remove(child);
		UpdateChildRectangles();
	}

	public abstract void UpdateChildRectangles();
}