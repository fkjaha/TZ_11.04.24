using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool GetIsGrounded => _isGrounded;
    
    [SerializeField] private Transform rayPointTransform;
    [SerializeField] private LayerMask rayCastLayer;
    [SerializeField] private float rayDistance;

    private bool _isGrounded;

    private void Update()
    {
        _isGrounded = Physics.Raycast(rayPointTransform.position, Vector3.down, rayDistance, rayCastLayer);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 rayPointPosition = rayPointTransform.position;
        Gizmos.DrawLine(rayPointPosition, rayPointPosition + Vector3.down * rayDistance);
    }
}