using ControlFreak2;
using UnityEngine;

public class AxisRotationInput : MonoBehaviour
{
    public Vector2 GetXYInput => _xyInput;

    private Vector2 _xyInput;

    private void Update()
    {
        if (CF2Input.touchCount == 0)
        {
            _xyInput = Vector2.zero;
            return;
        }

        InputRig.Touch firstTouch = CF2Input.GetTouch(0);
        _xyInput = firstTouch.deltaPosition;
    }
}