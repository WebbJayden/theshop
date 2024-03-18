using Godot;
using System;

public partial class SceneManager : Node
{
    

    // change scene method that takes the path directory as an argument
    public void ChangeScene(string path)
    {
        // get path of desired scene
        Global.CurrentScenePath = path;

        // get scene tree
        var tree = GetTree();

        // change scene to desired paths scene
        tree.ChangeSceneToFile(path);
    }

    // Collision detection
    public void _on_scenemanager_entered(CharacterBody2D body)
    {
        GD.Print($"Scene Manager entered: {body}");

        // if player enters SceneCollision, change scene

    }
}
