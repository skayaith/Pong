using Godot;
using System;

public partial class Ball : CharacterBody2D
{
    [Export] public float Speed = 250f;
    private Vector2 velocity = new Vector2(1, 0.5f);


    public override void _PhysicsProcess(double delta)
    {
        Vector2 motion = velocity * Speed * (float)delta;

        KinematicCollision2D collision = MoveAndCollide(motion);

        if (collision != null)
        {
            Vector2 normal = collision.GetNormal();
            velocity = velocity.Bounce(normal);
            Speed += 10f;
        }
    }

}
