using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Gold : MonoBehaviour
{
    [SerializeField] public  float _gold;
    [SerializeField] private Text TextGold;
   
    

    [SerializeField] private float StatrTime=1.5f;
    [SerializeField] private float EndTime=1.5f;

  
    void Start()
    {
        
    }
    private void Update()
    {

        PlusGold();

    }

    public void PlusGold()
    {
        if (StatrTime <= 0)
        {
            _gold++;
            StatrTime = EndTime;
        }
        else
        {
            StatrTime -= Time.deltaTime;
        }
        TextGold.text = _gold.ToString();

      



    }
}
