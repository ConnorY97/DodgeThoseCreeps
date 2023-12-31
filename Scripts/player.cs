using Godot;
using System;

public partial class player : Area2D
{
	[Export]
	public int Speed { get; set; } = 400; // How fast the player will move (pixels/sec).

	public Vector2 ScreenSize; // Size of the game window.
	
	public override void _Ready()
	{
		screenSize = GetViewportRect().Size;
	}
}
