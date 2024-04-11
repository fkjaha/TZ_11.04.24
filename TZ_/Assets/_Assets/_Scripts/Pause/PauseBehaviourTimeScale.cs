using System;
using UnityEngine;

public class PauseBehaviourTimeScale : MonoBehaviour
{
    [SerializeField] private PauseController pauseController;
    [SerializeField] private float pauseTimeScale;
    [SerializeField] private float defaultTimeScale;

    private void OnEnable()
    {
        pauseController.OnPaused += SetPauseTimeScale;
        pauseController.OnUnPaused += SetDefaultTimeScale;
    }

    private void OnDisable()
    {
        pauseController.OnPaused -= SetPauseTimeScale;
        pauseController.OnUnPaused -= SetDefaultTimeScale;
        SetDefaultTimeScale();
    }

    private void SetPauseTimeScale()
    {
        Time.timeScale = pauseTimeScale;
    }
    
    private void SetDefaultTimeScale()
    {
        Time.timeScale = defaultTimeScale;
    }
}