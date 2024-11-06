using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    [SerializeField] private Transform attackPoint;
    [SerializeField] private float radius;
    [SerializeField] private GameObject moneyPrefab;
    [SerializeField] private int maxCoinDrop;
    public LayerMask playerLayer;

    private Animator anim;
    private PlayerAnim playerAnim;
    private Skeleton skeleton;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerAnim = FindObjectOfType<PlayerAnim>();
        skeleton = GetComponentInParent<Skeleton>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnim(int value)
    {
        anim.SetInteger("transition", value);
    }

    public void Attack()
    {
        if(!skeleton.isDead)
        {
            Collider2D hit = Physics2D.OverlapCircle(attackPoint.position, radius, playerLayer);

            if(hit != null)
            {
                playerAnim.OnHit();
            }
        }
    }

    public void OnHit()
    {
        if(skeleton.currentHealth <= 0)
        {
            skeleton.isDead = true;
            anim.SetTrigger("death");

            int coinDrop = Random.Range(1, maxCoinDrop);
            for (var i = 0; i < coinDrop; i++)
            {
                Instantiate(moneyPrefab, transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f), transform.rotation);
            }

            Destroy(skeleton.gameObject, 1f);   
        }
        else
        {
            anim.SetTrigger("hit");
            skeleton.currentHealth--;

            skeleton.healthBar.fillAmount = skeleton.currentHealth / skeleton.totalHealth;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, radius);
    }
}
