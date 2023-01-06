using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LogicMoveEnumy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _home;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LogicTarget();
        
    }


    void LogicTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, _home.position, _speed * Time.deltaTime);
    }
}
