using UnityEngine;

public class YellowPotion : AutoCollect
{
    public int multiplier = 1;

    public override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        //Add Attributes
        Player.instance.GetComponent<health>().Health += 100 * multiplier;
    }
}