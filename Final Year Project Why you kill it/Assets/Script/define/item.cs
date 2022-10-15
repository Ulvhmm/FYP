using UnityEngine;

[CreateAssetMenu(fileName = "New Item")]
//, menuName = "Inventory/item")

public class item : ScriptableObject
{
    public new string name = "Item 1";
    public Sprite icon = null;
}
