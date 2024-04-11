using UnityEngine;

public class AxisRotationController : MonoBehaviour
{
    [SerializeField] private AxisRotationInput input;
    [SerializeField] private Transform rotationTarget;
    [SerializeField] private float sensitivity;

    private void Update()
    {
        if(PauseInfo.IsPaused) return;

        rotationTarget.Rotate(Vector3.up * (input.GetXYInput.x * sensitivity));
    }
}
