using ControlFreak2;
using UnityEngine;

public class PlayerMovementInput : MonoBehaviour
{
    public bool GetIsJumping => _jumpPressed;
    public Vector2 GetXZInput => _xzInput;

    private Vector2 _xzInput;
    private bool _jumpPressed;

    private void Update()
    {
        _xzInput = new Vector2(CF2Input.GetAxis("Horizontal"), CF2Input.GetAxis("Vertical"));
        _jumpPressed = CF2Input.GetButtonDown("Jump");
    }
}