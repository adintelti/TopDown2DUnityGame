using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    [Header("Attack Settings")]
    [SerializeField] private Transform attackPoint;
    [SerializeField] private float radius;
    [SerializeField] private LayerMask enemyLayer;

    private Player player;
    private Animator anim;
    private Casting cast;

    [SerializeField] private float recorveyTime;
    private bool isHitting;
    private float timeCount;

    private void Start()
    {
        player = GetComponent<Player>();
        anim = GetComponent<Animator>();
        cast = FindObjectOfType<Casting>();
    }

    private void Update()
    {
        OnMove();
        OnRun();

        if(isHitting)
        {
            timeCount += Time.deltaTime;
            if(timeCount >= recorveyTime)
            {
                isHitting = false;
                timeCount = 0f;
            }
        }
    }

    #region Movement

    private void OnMove()
    {
        if (player.movement.sqrMagnitude > 0)
        {
            if(player.isRolling)
            {
                if(!anim.GetCurrentAnimatorStateInfo(0).IsName("roll"))
                {
                    anim.SetTrigger("isRoll");
                }
            }
            else
            {
                anim.SetInteger("transition", 1);
            }
        }
        else
        {
            anim.SetInteger("transition", 0);
        }

        if(player.movement.x > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        } 
        else if(player.movement.x < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }

        if(player.isCutting)
        {
            anim.SetInteger("transition", 3);
        }
        else if(player.isDigging)
        {
            anim.SetInteger("transition", 4);
        }
        else if(player.isWatering)
        {
            anim.SetInteger("transition", 5);
        }
    }

    private void OnRun()
    {
        if(player.isRunning && player.movement.sqrMagnitude > 0)
        {
            anim.SetInteger("transition", 2);
        }
    }

    public void OnCastingStarted()
    {
        anim.SetTrigger("isCasting");
        player.isPaused = true;
    }

    public void OnCastingEnded()
    {
        cast.OnCasting();
        player.isPaused = false;
    }

    public void OnHammeringStarted()
    {
        anim.SetBool("hammering", true);
    }

    public void OnHammeringEnded()
    {
        anim.SetBool("hammering", false);
    }

    public void OnHit()
    {
        if(!isHitting)
        {
            anim.SetTrigger("hit");
            isHitting = true;
        }
    }
    #endregion

    #region Attack

    public void OnAttack()
    {
        Collider2D hit = Physics2D.OverlapCircle(attackPoint.position, radius, enemyLayer);

        if(hit != null)
        {
            hit.GetComponentInChildren<AnimationControl>().OnHit();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, radius);
    }

    #endregion
}
