using System;
using UnityEngine;

public class GameplayPauseUI : MonoBehaviour
{
    [SerializeField] private PauseController pauseController;
    [SerializeField] private GameObject pauseUI;

    private void OnEnable()
    {
        pauseController.OnPaused += SetActiveUI;
        pauseController.OnUnPaused += SetInactiveUI;
    }

    private void OnDisable()
    {
        pauseController.OnPaused -= SetActiveUI;
        pauseController.OnUnPaused -= SetInactiveUI;
    }

    private void SetActiveUI()
    {
        SetUIVisible(true);
    }
    
    private void SetInactiveUI()
    {
        SetUIVisible(false);
    }

    private void SetUIVisible(bool visible)
    {
        pauseUI.SetActive(visible);
    }
}