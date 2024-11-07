using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Dialogue : MonoBehaviour
{
    public float dialogueRange;
    public LayerMask playerLayer;
    public DialogSettings dialogue;
    public bool isShopNpc;

    private bool playerHit;

    private List<string> sentences = new List<string>();
    private List<string> actorNames = new List<string>();
    private List<Sprite> actorSprites = new List<Sprite>();
    
    void Start()
    {
        GetNPCInfo();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerHit)
        {
            if(isShopNpc)
                ShopControl.instance.ShowShop();
            else
                DialogueControl.instance.Speech(sentences.ToArray(), actorNames.ToArray(), actorSprites.ToArray());
        }
    }

    void FixedUpdate()
    {
        ShowDialogue();
    }
    
    void GetNPCInfo()
    {
        for (var i = 0; i < dialogue.dialogues.Count; i++)
        {
            switch (DialogueControl.instance.language)
            {
                case DialogueControl.idiom.pt:
                    sentences.Add(dialogue.dialogues[i].sentence.portuguese);
                    break;
                case DialogueControl.idiom.eng:
                    sentences.Add(dialogue.dialogues[i].sentence.english);
                    break;
                case DialogueControl.idiom.spa:
                    sentences.Add(dialogue.dialogues[i].sentence.spanish);
                    break;
            }

            actorNames.Add(dialogue.dialogues[i].ActorName);
            actorSprites.Add(dialogue.dialogues[i].profile);
        }
    }

    void ShowDialogue()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, dialogueRange, playerLayer);

        if(hit != null)
        {
            playerHit = true;
        }
        else
        {
            playerHit = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, dialogueRange);
    }
}
