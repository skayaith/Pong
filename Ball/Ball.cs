using Godot;
using System;

public partial class Ball : CharacterBody2D
{
    [Export] public float Speed = 250f;
    private Vector2 velocity = Vector2.Zero;
    private float minAngle = Mathf.DegToRad(30);
    private float maxAngle = Mathf.DegToRad(40);

    public override void _PhysicsProcess(double delta)
    {
        // no movement if velocity is zero
        if (velocity == Vector2.Zero)
        {
            return;
        }

        Vector2 motion = velocity.Normalized() * Speed * (float)delta; // normalized so that the speed is consistent regardless of direction

        KinematicCollision2D collision = MoveAndCollide(motion);

        // increase ball speed on collision
        if (collision != null)
        {
            Vector2 normal = collision.GetNormal();
            velocity = velocity.Bounce(normal);
            Speed += 10f;
        }
    }

    public void StartBall()
    {


        float angle = (float)GD.RandRange(minAngle, maxAngle); // random starting angle
        angle *= GD.Randf() < 0.5f ? 1 : -1;
        float direction = GD.Randf() < 0.5f ? 1 : -1; // random starting direction

        velocity = new Vector2(Mathf.Cos(angle) * direction, Mathf.Sin(angle)).Normalized();
        
    }

    public void ResetBall()
    {
        GlobalPosition = new Vector2(576, 320);
        Speed = 250f;
        velocity = Vector2.Zero;
    }

}
