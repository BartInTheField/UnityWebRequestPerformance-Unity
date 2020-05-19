using System;
using System.Collections;
using System.Collections.Generic;
using BartInTheField.Timer;
using TMPro;
using UnityEngine;

public class FPSEndPanel : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private TextMeshProUGUI textMesh;
    [SerializeField] private FPSCounter fpsCounter;

    private CanvasGroup _canvasGroup;

    private void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 0;
        
        timer.OnTimeout += ShowFPS;
    }

    private void ShowFPS()
    {
        _canvasGroup.alpha = 1;
        textMesh.text = fpsCounter.AverageFPS + "";
    }
}
