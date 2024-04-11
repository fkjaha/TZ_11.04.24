using System;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public bool IsMoving => _xzMovement != Vector3.zero;
    public Vector3 GetMovementDirection => _xzMovement;
    
    [SerializeField] private PlayerMovementInput input;
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Transform movementDirectionTransform;
    [SerializeField] private float speed;
    [SerializeField] private float gravity;
    [SerializeField] private float jumpForce;
    
    private Vector3 _xzMovement;
    private float _yMovement;

    private void Update()
    {
        if(PauseInfo.IsPaused) return;
        
        MoveY(input.GetIsJumping);
        MoveXZ(input.GetXZInput.normalized);
    }

    private void MoveXZ(Vector2 xzInput)
    {
        Vector3 rightMovement = movementDirectionTransform.right * xzInput.x;
        Vector3 forwardMovement = movementDirectionTransform.forward * xzInput.y;
        _xzMovement = (forwardMovement + rightMovement) * speed * Time.deltaTime;
        characterController.Move(_xzMovement);
    }

    private void MoveY(bool isJumping)
    {
        ProcessYMovement(isJumping);
        characterController.Move(Vector3.up * _yMovement * Time.deltaTime);
    }

    private void ProcessYMovement(bool isJumping)
    {
        if (groundChecker.GetIsGrounded)
        {
            if(_yMovement < 0)
                ResetYMovement();
            
            if(isJumping) 
                Jump();
        }

        ApplyGravityToYMovement();
    }

    private void ResetYMovement()
    {
        _yMovement = 0;
    }

    private void Jump()
    {
        _yMovement += Mathf.Sqrt(jumpForce * gravity);
    }

    private void ApplyGravityToYMovement()
    {
        _yMovement -= gravity * Time.deltaTime;
    }
}