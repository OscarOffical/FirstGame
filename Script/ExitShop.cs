using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitShop : MonoBehaviour
{
    public GameObject exit;
   
   public void Exit()
    {
        exit.SetActive(false);
        Time.timeScale= 1.0f;

    }
   
}
