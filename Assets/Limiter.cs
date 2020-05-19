using System;
using System.Collections;
using System.Collections.Generic;
using BartInTheField.Timer;
using UnityEngine;

public class Limiter : MonoBehaviour
{
    [SerializeField] private FPSCounter fpsCounter;
    [SerializeField] private Timer timer;

    private void Start()
    {
        timer.OnTimeout += StopBenchmark;
    }

    private void StopBenchmark()
    {
        print(fpsCounter.AverageFPS);
    }
}
