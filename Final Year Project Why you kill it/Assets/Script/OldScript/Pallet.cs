using UnityEngine;

public class Pallet : Interactable
{
    public override void Interact()
    {
        base.Interact();
        interactableRadius = 0;

        // display animation 
        Animator animator = GetComponent<Animator>();
        animator.SetBool("IsOpen", !animator.GetBool("IsOpen"));
    }
}
