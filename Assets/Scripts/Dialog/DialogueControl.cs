using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [System.Serializable]
     public enum idiom
    {
        pt,
        eng,
        spa
    }

    public idiom language;

    [Header("Components")]
    public GameObject dialogueObj; //janela do dialogo
    public Image profileSprite; //sprite do perfil
    public Text speechText; //texto da fala
    public Text actorNameText; //nome do npc

    [Header("Components")]
    public float typingSpeed; //velocidade da fala

    private bool _isShowing; //se a janela esta visível
    private int index; //index das sentenças
    private string[] sentences;

    public static DialogueControl instance;

    public bool isShowing { get => _isShowing; set => _isShowing = value; }

    void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }

    void Update()
    {
        
    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    //pula para próxima frase/fala
    public void NextSentence()
    {
        if(speechText.text == sentences[index])
        {
            if(index < sentences.Length - 1)
            {
                index++;
                speechText.text = "";
                StartCoroutine(TypeSentence());
            }
            else
            {
                speechText.text = "";
                index = 0;
                dialogueObj.SetActive(false);
                sentences = null;
                _isShowing = false;
            }
        }
    }

    //Chama a fala do NPC
    public void Speech(string[] txt)
    {
        if(!_isShowing)
        {
           dialogueObj.SetActive(true);
           sentences = txt;
           StartCoroutine(TypeSentence()); 
           _isShowing = true;
        }
    }
}
