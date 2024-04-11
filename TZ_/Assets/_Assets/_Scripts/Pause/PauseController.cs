using System;
using UnityEngine;
using UnityEngine.Events;

public class PauseController : MonoBehaviour
{
    public event UnityAction OnPaused;
    public event UnityAction OnUnPaused;
    
    public bool GetIsPaused => _isPaused;

    private bool _isPaused;
    
    public void TogglePause()
    {
        SetPauseActive(!_isPaused);
    }
    
    public void SetPauseActive(bool active)
    {
        if(_isPaused == active) return;
        
        _isPaused = active;
        (_isPaused ? OnPaused : OnUnPaused)?.Invoke();
    }
}