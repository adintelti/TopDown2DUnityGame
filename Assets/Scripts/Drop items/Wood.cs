using UnityEngine;
using UnityEngine.InputSystem;

public class Wood : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeMove;
    [SerializeField] private AudioSource _audioSource;

    private float timeCount;
    private bool playSFX;

    void Update()
    {
        timeCount += Time.deltaTime;

        if(timeCount < timeMove)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(collision.GetComponent<PlayerItems>().CollectWood())
            {
                collision.GetComponent<PlayerItems>().AddWood(1);
                Destroy(gameObject);
            }
        }
    }

    public void ToogleSound(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            playSFX = !playSFX;
        }
        _audioSource.mute = playSFX;
    }
}
