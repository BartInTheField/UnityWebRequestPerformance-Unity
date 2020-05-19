using System;
using System.Collections;
using System.Collections.Generic;
using BartInTheField.Timer;
using UnityEngine;

public class Requester : MonoBehaviour
{
    [SerializeField] private Timer timer;
    
    private int[] _data =  {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    private RequestHelper _requesterHelper = new RequestHelper();

    private void Start()
    {
        timer.OnTimeout += SendRequest;
    }

    private void SendRequest()
    {
        _requesterHelper.Post("http://localhost:3000", _data);
    }
}
