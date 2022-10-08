using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class CalculateDistance : MonoBehaviour
{
    public static CalculateDistance instance;
    public float distance;
    public GameObject hand;
    public GameObject target;

    private void Awake()
    {
        instance = this;   
    }
    void Start()
    {
        
    }

   
    void Update()
    {
       
    }

    public float getDistance()
    {
        distance = Vector3.Distance(hand.transform.position, target.transform.position);
        return distance;
           
    }


}
