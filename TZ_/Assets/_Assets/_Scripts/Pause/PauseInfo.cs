using UnityEngine;

public class PauseInfo : MonoBehaviour
{
    public static bool IsPaused => _pauseController.GetIsPaused;
    
    [SerializeField] private PauseController pauseController;
    
    private static PauseController _pauseController;

    private void Awake()
    {
        _pauseController = pauseController;
    }
}