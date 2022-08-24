using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stairss : MonoBehaviour
{
    public GameObject Obj;
   
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MeshRenderer m = Obj.GetComponent<MeshRenderer>();
            m.enabled = true;
            Debug.Log("loststair");
        }
    }



}