using KokoObjectGui.GuiItems.Interfaces;
using KokoObjectGui.GuiItems.Parentables;
using KokoObjectGui.Helpers;

namespace KokoObjectGui;

public class Gui : AParentElement, IParentable {
	private Gui() { }
	public static Gui Instance { get; private set; } = new();

	public override void UpdateChildRectangles() => PanelRectangle.UpdateRectangleForPanel(new Rectangle(0,0,0,0), ChildElements);

	/// <summary>
	/// Tells to draw but not how to draw.
	/// </summary>
	public void Draw() {
		ChildElements.ForEach(child => {
			DrawChild(child);

			if (child is IParentable parentable) {
				Draw(parentable);
			}
		});
	}
	
	private void Draw(IParentable parentable) {
		parentable.ChildElements.ForEach(child => {
			DrawChild(child);

			if (child is IParentable parentable) {
				Draw(parentable);
			}
		});
	}

	public void DrawChild(IGuiItem child) {
		if (child is IWriteable writeable) {
			writeable.Draw?.Invoke(new Rectangle(writeable.X, writeable.Y, writeable.Width, writeable.Height), new Writable(
				writeable.TextColor,
				writeable.Text
			));

			return;
		}

		if (child is IRectable rectable) {
			rectable.Draw?.Invoke(new Rectangle(rectable.X, rectable.Y, rectable.Width, rectable.Height));
		}
	}
}
