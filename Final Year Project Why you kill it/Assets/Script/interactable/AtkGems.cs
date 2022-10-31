using UnityEngine;

public class AtkGems : AutoCollect
{
    public int multiplier = 1;

    public override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        //Add Attributes
        PlayerAttributes.instance.Attack += 1 * multiplier;
    }
}
