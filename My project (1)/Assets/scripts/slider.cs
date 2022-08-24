using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    [SerializeField]
    Transform strat, finish;
    [SerializeField]
    Slider gostergeslider;
    float starty, finishy;


    void Start()
    {
        starty = strat.position.y;
        finishy = finish.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float gostergeoraný = Mathf.InverseLerp(starty, finishy, Player.transform.position.y);
        gostergeslider.value=gostergeoraný;
        
    }
}
