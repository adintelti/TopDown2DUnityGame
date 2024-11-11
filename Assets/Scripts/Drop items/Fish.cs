using UnityEngine;

public class Fish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(collision.GetComponent<PlayerItems>().CollectFish())
            {
                collision.GetComponent<PlayerItems>().AddFish(1);
                Destroy(gameObject);
            }
        }
    }
}
