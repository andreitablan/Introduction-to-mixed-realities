using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    
    void Update()
    {

        if (m_Animator != null)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                m_Animator.SetTrigger("PeaceTrigger");
  
            }
            if (Input.GetKeyUp(KeyCode.P))
            {
                m_Animator.SetTrigger("PeaceReleaseTrigger");

            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                m_Animator.SetTrigger("GrabTrigger");

            }
            if (Input.GetKeyUp(KeyCode.G))
            {
                m_Animator.SetTrigger("GrabReleaseTrigger");

            }
        }
    }
}
