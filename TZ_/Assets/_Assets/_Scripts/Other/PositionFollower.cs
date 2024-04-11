using UnityEngine;

public class PositionFollower : MonoBehaviour
{
    [SerializeField] private Transform followingTransform;
    [SerializeField] private Transform followedTransform;
    [SerializeField] private Vector3 followOffset;

    private void Update()
    {
        followingTransform.position = followedTransform.position + followOffset;
    }
}
