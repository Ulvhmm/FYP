using UnityEngine;

public class DefGems : AutoCollect
{
    public int multiplier = 1;

    public override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        //Add Attributes
        Player.instance.GetComponent<PlayerAttributes>().Defence += 1 * multiplier;
    }
}
