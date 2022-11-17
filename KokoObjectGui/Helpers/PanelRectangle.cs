using KokoObjectGui.GuiItems.Interfaces;

namespace KokoObjectGui.Helpers;

/// <summary>
/// Made because GUI also uses the same method but doesn't care about the internal Panel class.
/// </summary>
public static class PanelRectangle {

	/// <summary>
	/// Made because GUI also uses the same method but doesn't care about the internal Panel class.
	/// </summary>
	public static void UpdateRectangleForPanel(Rectangle parentRect, List<IGuiItem> ChildElements) {
		Rectangle containerData = new(0, 0, 0, 0);
		for (int i = 0; i < ChildElements.Count; i++) {
			if (ChildElements[i] is not IRectable)
				continue;

			var ce = (IRectable)ChildElements[i];
			if (i == 0) {
				containerData = new(ce.X + parentRect.X, ce.Y + parentRect.Y, ce.Width + parentRect.Width, ce.Height + parentRect.Height);
				containerData = UpdateRectangle(ce, containerData);
				continue;
			}

			containerData = UpdateRectangle(ce, containerData);
		}
	}
	
	public static Rectangle UpdateRectangle(IRectable ce, Rectangle containerData) {
		ce.UpdateRectangle(containerData);
		return new(ce.X + ce.Height, ce.Y + ce.Width, ce.Width, ce.Height);
	}
}
