using Godot;
using Godot.Collections;
using System;

public partial class DialogueManager : Control
{
    // create dictionary to contain dialogue for shopkeep
    private Dictionary<string, string[]> dialogues = new Dictionary<string, string[]>
    {
        // initial key string
        // create 'new string' for value(s)
        { "Shopkeep", new string[] { "welcome.", "you new around here?", "nice to see a new face every now and again.", "sometimes there's strange noises from that room back there. i wouldn't worry about it heh heh heh."} }
    };
}
