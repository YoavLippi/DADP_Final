using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimControl: MonoBehaviour
{
    private Animator _anim;          
    private PlayerController _playerController;
    public KhopeshAttack _KhopeshAttack;

    void Start()
    {
       
        _anim = GetComponent<Animator>();
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (Mathf.Abs(_playerController.moveDirection.x) < 3f && Mathf.Abs(_playerController.moveDirection.z) < 3f)
        {
            _anim.SetInteger("AnimState", 0);   // Play Idle animation
        }
        else
        {
            _anim.SetInteger("AnimState", 1);   // Play Walk anwimation
        }
        
        
        if (Input.GetButtonDown("Fire1"))
        {
            _anim.SetInteger("AnimState" , 2);
            if (!_KhopeshAttack.isAttacking)
            {
                StartCoroutine(waitForAnimation());
            }
        }
        
    }

    private IEnumerator waitForAnimation()
    {
        bool switcher = false;
        while (true)
        {
            yield return new WaitForFixedUpdate();
            if (_anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                _KhopeshAttack.isAttacking = true;
                switcher = true;
            }

            if (switcher)
            {
                if (!_anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
                {
                    _KhopeshAttack.isAttacking = false;
                    break;
                }
            }
        }
    }
}