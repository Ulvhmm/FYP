using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable
{
    //public GameObject Mission;
    //public GameObject DisabledMission;

    public Dialogue dialogue;

    public bool interactable = true;

    public bool firstInteraction = true;

    public GameObject nextNPC;

    public GameObject ItemNumber;

    public GameObject DisabledNPC;

    public override void Interact()
    {
        if (!interactable)
        {
            return;
        }

        else
        {
            base.Interact();
        }

        if (firstInteraction)
        {
            DialogueManager.instance.StartDialogue(dialogue);
            Player.instance.GetComponent<PlayerMovement>().canMove = false;
            firstInteraction = false;
            //DisabledMission.SetActive(false);
        }

        else
        {
            if (!DialogueManager.instance.DisplayNextSentence())
            {
                firstInteraction = true;
                Player.instance.GetComponent<PlayerMovement>().canMove = true;
                //Mission.SetActive(true);
                DisabledNPC.SetActive(false);

                if (nextNPC != null)
                {
                    nextNPC.SetActive(true);
                }
            }
        }
    }
}
