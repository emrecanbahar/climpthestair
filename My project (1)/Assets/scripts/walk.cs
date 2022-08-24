using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public static walk Current;

    [SerializeField] float movemspeed;
    [SerializeField] float harspeed;
    float har;
    public Animator anim;
    

    public Transform stair;
    Transform parent;
    int pointer;
    
    

    void Start()
    {
        parent = transform.parent;
        pointer = 0;
        anim = GetComponent<Animator>();
        
    }



        private void Update()
        {
        if (Input.GetMouseButton(0))    
        {
            Jumping();
        }
        }
    
        public void Jumping()
        {
        anim.SetTrigger("ýdle");
            parent.position = stair.GetChild(pointer).position;
            pointer++;
           // har = Input.GetAxis("Horizontal");
           // transform.Translate(new Vector3(har * harspeed * Time.deltaTime, 0, movemspeed * Time.deltaTime));
            Debug.Log("stiarup");
       
        }
}
