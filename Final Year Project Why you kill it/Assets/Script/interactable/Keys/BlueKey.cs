using UnityEngine;

public class BlueKey : AutoCollect
{
    public override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        //Add Key
        Player.instance.GetComponent<PlayerKeys>().Blue_Key += 1;
    }
}