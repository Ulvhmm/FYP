using UnityEngine;

public class BluePotion : AutoCollect
{
    public int multiplier = 1;
    public int BaseHealth = 200;

    public override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        //Add Attributes
        Player.instance.GetComponent<health>().Health += BaseHealth * multiplier;
    }
}