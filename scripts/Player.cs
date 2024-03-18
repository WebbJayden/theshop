using Godot;
using System;

public partial class Player : CharacterBody2D
{
    /*---------------
        MOVEMENT
     ---------------*/

    // set player move speed
    [Export]
    private float _speed;

    // get player direction
    private Vector2 _direction;

    // get player velocity
    private Vector2 _velocity;

    /*---------------
     NODE REFERENCES
     ---------------*/

    // get player sprite
    private Sprite2D _sprite;

    public override void _Ready()
    {
        // _velocity = Velocity;

        _sprite = (Sprite2D)GetNode("PlayerSprite");
    }

    public override void _PhysicsProcess(double delta)
    {
        /*---------------
            MOVEMENT
        ---------------*/

        // set direction to relevant input vector
        // set vector names in project settings in input map
        _direction = Input.GetVector("move_left", "move_right", "move_up", "move_down");

        // get velocity based off direction and speed
        Velocity = _direction * _speed;

        GD.Print($"velocity: {Velocity}");

        // move character based on _velocity value
        MoveAndSlide();

        // flip character sprite based on input vector
        // if input x value < 0.0, flipH true
        // if input x value > 0.0, flipH false
        _sprite.FlipH = _direction.X < 0.0;

        /*---------------
            MOVEMENT
        ---------------*/
    }
}
