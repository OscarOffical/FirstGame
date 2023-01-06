using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagEnumy : MonoBehaviour
{
    float _damag = 1;
    
    
    
    private void OnTriggerStay2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Home"))
        {
           
            collision.gameObject.GetComponent<HpBarHome>().TakeDamag(_damag);
            Destroy(gameObject);
        }
       
       
    }

    

}
