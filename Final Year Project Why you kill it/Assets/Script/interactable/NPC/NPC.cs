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

    public NPC nextNPC;

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
            firstInteraction = false;
            //DisabledMission.SetActive(false);
        }

        else
        {
            if (!DialogueManager.instance.DisplayNextSentence())
            {
                firstInteraction = true;
                //Mission.SetActive(true);
                //DisabledNPC.SetActive(false);

                if (nextNPC != null)
                {
                    nextNPC.interactable = true;
                }
            }
        }
    }
}
