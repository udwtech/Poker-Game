using Godot;
using System;
using System.Threading;

public class RaiseBtn : Button
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("HI Im Alive");
	}

	// This Test Code is a sample code to make the button to be active and back to active after some interval , useful when the contract is being signed and submitted to the network to be updated.
	public override void _Pressed(){
		GD.Print($"{nameof(RaiseBtn)} was pressed.");
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
