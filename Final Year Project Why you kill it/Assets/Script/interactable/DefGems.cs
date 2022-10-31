using UnityEngine;

public class DefGems : AutoCollect
{
    public int multiplier = 1;

    public override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        //Add Attributes
        PlayerAttributes.instance.Defence += 1 * multiplier;
    }
}
