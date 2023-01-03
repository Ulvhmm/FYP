using UnityEngine;

public class YellowKey : AutoCollect
{
    public override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        //Add Key
        Player.instance.GetComponent<PlayerKeys>().Yellow_Key += 1;
    }
}