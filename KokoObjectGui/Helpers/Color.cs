namespace KokoObjectGui.Helpers;
public struct Color {
	public byte R;
	public byte G;
	public byte B;
	public float A;

	public Color(byte r, byte g, byte b, float a) {
		if (a < 0) a = 0;
		if (a > 1) a = 1;
		R = r;
		G = g;
		B = b;
		A = a;
	}
}
