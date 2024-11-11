using System.Collections;
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
    private string[] _currentActorName;
    private Sprite[] _actorSprite;

    private Player _player;

    public static DialogueControl instance;

    public bool isShowing { get => _isShowing; set => _isShowing = value; }

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        _player = FindObjectOfType<Player>();
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
                profileSprite.sprite = _actorSprite[index];
                actorNameText.text = _currentActorName[index];
                speechText.text = "";
                StartCoroutine(TypeSentence());
            }
            else
            {
                speechText.text = "";
                actorNameText.text = "";
                index = 0;
                dialogueObj.SetActive(false);
                sentences = null;
                _isShowing = false;
                _player.isPaused = false;
            }
        }
    }

    //Chama a fala do NPC
    public void Speech(string[] txt, string[] actorName, Sprite[] actorProfile)
    {
        if(!_isShowing)
        {
           dialogueObj.SetActive(true);
           sentences = txt;
           _actorSprite = actorProfile;
           _currentActorName = actorName;
            profileSprite.sprite = _actorSprite[index];
            actorNameText.text = _currentActorName[index];
           StartCoroutine(TypeSentence()); 
           _isShowing = true;
           _player.isPaused = true;
        }
    }
}
