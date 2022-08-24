using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextlevelmenu : MonoBehaviour
{
    public GameObject nextlevelpnl;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Saw"))
        {
            nextlevelpnl.SetActive(true);
        }
        

    }

   
    
}
