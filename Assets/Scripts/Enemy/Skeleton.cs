using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Skeleton : MonoBehaviour
{
    [Header("Stats")]
    public float totalHealth;
    public float currentHealth;
    public Image healthBar;
    public bool isDead;
    public float radius;
    public LayerMask layer;

    [Header("Components")]
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private AnimationControl animControl;

    [SerializeField] private AudioSource _audioSource;

    private Player player;
    private bool _detectPlayer;
    private bool playSFX;

    void Start()
    {
        currentHealth = totalHealth;
        player = FindObjectOfType<Player>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        if(!isDead && _detectPlayer)
        {
            agent.isStopped = false;
            agent.SetDestination(player.transform.position);

            if(Vector2.Distance(transform.position, player.transform.position) <= agent.stoppingDistance)
            {
                //chegou no limite de distancia
                animControl.PlayAnim(2); //atacando
            }
            else
            {
                //skeleton segue o player
                animControl.PlayAnim(1); //andando
            }

            float posX = player.transform.position.x - transform.position.x;
            if(posX > 0)
            {
                transform.eulerAngles = new Vector2(0, 0);
            }
            else
            {
                transform.eulerAngles = new Vector2(0, 180);
            }
        }
    }

    void FixedUpdate()
    {
        DetectPlayer();
    }

    public void DetectPlayer()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, layer);

        if(hit != null)
        {
            //enemy seeing player
            _detectPlayer = true;
        }
        else
        {
            //enemy not seeing player
            _detectPlayer = false;
            animControl.PlayAnim(0);
            agent.isStopped = true;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
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
