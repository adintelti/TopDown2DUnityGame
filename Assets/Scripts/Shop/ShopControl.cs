using UnityEngine;

public class ShopControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject shopDialogueObj;

    public static ShopControl instance;

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

    public void ShowShop()
    {
        if (!_isShowing)
        {
            shopDialogueObj.SetActive(true);
            _player.isPaused = true;
            _isShowing = true;
        }
    }

    public void HideShop()
    {
        shopDialogueObj.SetActive(false);
        _player.isPaused = false;
        _isShowing = false;
    }
}
