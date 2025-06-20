using Godot;
using System;

public partial class Paddle : CharacterBody2D
{
	
	[Export] public int Speed = 300;
    [Export] public bool IsPlayer1 = true;

	public override void _PhysicsProcess(double delta)
    {
        var velocity = Vector2.Zero;

        if (IsPlayer1)
        {
            if (Input.IsActionPressed("player1_up")) velocity.Y -= 1;

            if (Input.IsActionPressed("player1_down")) velocity.Y += 1;
        }

        else
        {
            if (Input.IsActionPressed("player2_up")) velocity.Y -= 1;

            if (Input.IsActionPressed("player2_down")) velocity.Y += 1;
        }
        
        

        Velocity = velocity.Normalized() * Speed;
        MoveAndSlide();
    }
	
	
	
}
