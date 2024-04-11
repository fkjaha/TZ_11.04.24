using UnityEngine;

public class PlayerModelRotation : MonoBehaviour
{
    [SerializeField] private Transform modelTransform;
    [SerializeField] private PlayerMovementController playerMovementController;

    private void Update()
    {
        if (playerMovementController.IsMoving)
        {
            SetModelDirectionToMovementDirection();    
        }
    }

    private void SetModelDirectionToMovementDirection()
    {
        modelTransform.rotation = Quaternion.LookRotation(playerMovementController.GetMovementDirection);
    }
}