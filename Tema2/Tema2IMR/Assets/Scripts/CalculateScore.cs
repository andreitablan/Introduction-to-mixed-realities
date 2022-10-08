using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculateScore : MonoBehaviour
{
    public float score = 0;
    public GameObject changingText;
    public static CalculateScore instance;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
      

    }
    void Update()
    {
       
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Arrow")
        {
            score = score + (int)CalculateDistance.instance.getDistance();            
            this.changingText.GetComponent<Text>().text = score.ToString();
        }
        
    } 
}
