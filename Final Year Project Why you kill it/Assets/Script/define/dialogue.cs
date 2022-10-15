using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string[] names;

    [TextArea(2,5)]
    public string[] sentences;
}
