using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimControl: MonoBehaviour
{
    private Animator _anim;          
    private PlayerController _playerController;  

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
            _anim.SetInteger("AnimState", 1);   // Play Walk animation
        }
        
        
        
        if (Input.GetButtonDown("Fire1"))
        {
            _anim.SetTrigger("Attack");   
        }
        
    }
}