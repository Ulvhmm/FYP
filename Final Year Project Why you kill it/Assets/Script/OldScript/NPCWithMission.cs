using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCWithMission : NPC
{
    public GameObject Key;
    public GameObject Gasoline;
    public GameObject Spanner;

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
            DisabledMission.SetActive(false);
        }

        else
        {
            if (!DialogueManager.instance.DisplayNextSentence())
            {
                firstInteraction = true;
                Mission.SetActive(true);
                Key.SetActive(true);
                Gasoline.SetActive(true);
                Spanner.SetActive(true);
                ItemNumber.SetActive(true);

                if (nextNPC != null)
                {
                    nextNPC.interactable = true;
                }
            }
        }
    }
}
