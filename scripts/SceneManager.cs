using Godot;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class SceneManager : Area2D
{
    // get the current scene property
    public Node CurrentScene { get; set; }

    // get/set next scene property
    public Node NextScene { get; set; }

    // Collision detection
    public void _on_scenemanager_entered(CharacterBody2D body)
    {
        GD.Print($"Scene Manager entered: {body}");
    }

    // if player enters SceneCollision, change scene


}
