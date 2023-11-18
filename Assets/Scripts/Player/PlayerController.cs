using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    public Camera playerCamera;
    public float walkSpeed = 6f;
    public float runSpeed = 12f;
    public float JumpPower = 7f;
    public float gravity = 10f;
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    public Vector3 moveDirection = Vector3.zero;

    private float rotationX = 0;
    private bool canMove = true;
    private int jumps;
    

    private CharacterController _characterController;

    public void Start()
    {
        _characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    public void Update()
    {
        #region Handles Movement
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 right = transform.TransformDirection(Vector3.right);
            
            //Shift to run
            bool isRunning = Input.GetKey(KeyCode.LeftShift);
            float curSpeedX = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Vertical") : 0;
            float curSpeedY = canMove ? (isRunning ? runSpeed : walkSpeed) * Input.GetAxis("Horizontal") : 0;
            float movementDirectionY = moveDirection.y;
            moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        #endregion

        #region Handles Jumping

            if (Input.GetButtonDown("Jump") && canMove && (_characterController.isGrounded || jumps>0 ))
            {
                moveDirection.y = JumpPower;
                 jumps--;
            }
            else
            {
                moveDirection.y = movementDirectionY;
            }

            if (!_characterController.isGrounded)
            {   
                moveDirection.y -= gravity * Time.deltaTime;
            }else
        {
            jumps = 1;
        }
        #endregion

        #region Handles Rotation
            _characterController.Move(moveDirection * Time.deltaTime);

            if (canMove && Time.timeScale != 0)
            {
                rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
                rotationX = Math.Clamp(rotationX, -lookXLimit, lookXLimit);
                playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0 , 0 );
                transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
            }

        #endregion

    }
}
