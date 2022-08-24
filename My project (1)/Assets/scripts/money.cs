using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    public moneymanager game;
    
    
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            game.monney++;
            game.money_text.text = game.monney.ToString();
            
        }
    }

}
