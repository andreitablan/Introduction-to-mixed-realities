using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator m_Animator;
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(m_Animator != null)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_Animator.SetTrigger("TrAttack");
            }
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Cactus2" || collider.tag == "Cactus1")
        {
            Debug.Log("am intrat in collider ");
            m_Animator.SetTrigger("TrAttack");
        }
    }
}
