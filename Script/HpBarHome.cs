using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarHome : MonoBehaviour
{
    [SerializeField] private float _healh = 5;

    [SerializeField] private Slider _slider;
    
    
    void Start()
    {

        _slider.maxValue = _healh;
        _slider.value= _healh;
    }


    public void TakeDamag(float  Damag)
    {
        
         _healh -= Damag;
        _slider.value = _healh;

        if (_healh == 0)
        {
            Destroy(gameObject);
        }
    }

}
