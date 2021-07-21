using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puxarMola : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    SpringJoint m_SpringJoint;
    public float m_Speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
        m_SpringJoint = GetComponent<SpringJoint>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            Vector3 m_Input = new Vector3(0, 0, -1);
            
            if(transform.position.z < -6.7)
                m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
            m_SpringJoint.spring = 0;
            m_SpringJoint.damper = 0;
        }else{
            m_SpringJoint.spring = 200;
            m_SpringJoint.damper = 1;
        }
    }
}
