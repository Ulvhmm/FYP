using UnityEngine;

public class RedKey : AutoCollect
{
    public override void Interact()
    {
        base.Interact();
        Destroy(gameObject);
        //Add Key
        Player.instance.GetComponent<PlayerKeys>().Red_Key += 1;
    }
}