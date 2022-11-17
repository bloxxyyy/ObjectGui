namespace KokoObjectGui.Helpers;

public struct Rectangle {
	public uint X = 0;
	public uint Y = 0;
	public uint Width = 0;
	public uint Height = 0;
	
	public Rectangle(uint x, uint y, uint width, uint height) {
		X = x;
		Y = y;
		Width = width;
		Height = height;
	}
}
