using Godot;
using System;



public partial class main : Node2D
{
	void _on_play_pressed()
	{
		GetTree().ChangeSceneToFile("res://game_board.tscn");
	}


	void _on_quit_pressed()
	{
		GetTree().Quit();
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}



