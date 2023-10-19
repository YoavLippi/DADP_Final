using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackAnim : MonoBehaviour
{
    private Animator animator;
    public bool midanimation;
    public KhopeshAttack knife;

    private void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (animator != null)
            {
                if (!knife.attacking)
                {
                    animator.SetTrigger("Attack");
                    StartCoroutine(attack());
                }
            }
        }
    }

    private IEnumerator attack()
    {
        knife.attacking = true;
        yield return new WaitForSeconds(0.7f);
        knife.attacking = false;
    }
}
