using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string[] names;

    [TextArea(2, 6)]
    public string[] sentences; 
}
