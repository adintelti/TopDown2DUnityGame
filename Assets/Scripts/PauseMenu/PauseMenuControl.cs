using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject pauseMenuHudObj;

    public static PauseMenuControl instance;

    [Header("SelectUIColors")]
    [SerializeField] private Color selectedColor;
    [SerializeField] private Color unSelectedColor;

    [Header("LanguageButtons")]
    [SerializeField] private GameObject englishButton;
    [SerializeField] private GameObject portugueseButton;
    [SerializeField] private GameObject spanishButton;

    [Header("SoundButton")]
    [SerializeField] private GameObject muteButton;

    public bool currentSoundState;

    private Player _player;
    private bool _isShowing;
    public bool isShowing { get => _isShowing; set => _isShowing = value; }

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        _player = FindObjectOfType<Player>();
    }

    public void TogglePauseMenu()
    {
        if (!_isShowing)
        {
            pauseMenuHudObj.SetActive(true);
            _player.isPaused = true;
            _isShowing = true;
        }
        else
        {
            pauseMenuHudObj.SetActive(false);
            _player.isPaused = false;
            _isShowing = false;
        }
    }

    public void ToggleSoundUI()
    {
        Text muteText = muteButton.GetComponent<Text>();

        if (currentSoundState)
            muteText.text = "OFF";
        else
            muteText.text = "ON";

        currentSoundState = !currentSoundState;
    }

    public void RestartCurrentScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void SelectLanguage(int langId)
    {
        Text englishText = englishButton.GetComponent<Text>();
        Text portugueseText = portugueseButton.GetComponent<Text>();
        Text spanishText = spanishButton.GetComponent<Text>();

        switch (langId)
        {
            case 0:
                englishText.color = selectedColor;
                portugueseText.color = unSelectedColor;
                spanishText.color = unSelectedColor;
                break;
            case 1:
                englishText.color = unSelectedColor;
                portugueseText.color = selectedColor;
                spanishText.color = unSelectedColor;
                break;
            case 2:
                englishText.color = unSelectedColor;
                portugueseText.color = unSelectedColor;
                spanishText.color = selectedColor;
                break;
            default:
                break;
        }
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                // Encerra o jogo no build final
                Application.Quit();
        #endif
    }
}
