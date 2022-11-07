using UnityEngine;

public class AtkGems : AutoCollect
{
    public int multiplier = 1;

    public override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        //Add Attributes
        Player.instance.GetComponent<PlayerAttributes>().Attack += 1 * multiplier;
    }
}
