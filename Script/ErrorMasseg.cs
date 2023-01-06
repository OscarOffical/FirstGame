using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorMasseg : MonoBehaviour
{
    [SerializeField] private float _starTime;
    [SerializeField] private float _emdTime = 3f;

    void Start()
    {
        gameObject.SetActive(false);
        _starTime = _emdTime;
    }
    private void Update()
    {
        ExitMassag();
    }

    public void ActiomMassag(bool _action)
    {
       
        if(_action==true)
        {
            gameObject.SetActive(true);
            
        }

    }
    public void ExitMassag()
    {
        if (_starTime <= 0)
        {
            gameObject.SetActive(false);
            _starTime = _emdTime;

        }else
        {
            _starTime -= Time.deltaTime;
        }
    }


}
