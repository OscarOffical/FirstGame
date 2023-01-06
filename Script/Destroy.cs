using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    [SerializeField] float _timeDestroy;
    void Start()
    {
        Destroy(gameObject, _timeDestroy);
    }

   
}
