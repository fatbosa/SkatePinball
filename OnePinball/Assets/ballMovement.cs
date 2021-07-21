using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public static int score = 0;
    public static int maxScore = 0;
    public Vector3 origem = new Vector3(0,0,0);
    AudioSource m_MyAudioSource;
    public AudioClip[] audio = new AudioClip[4];
    bool m_Play;
    bool changed;


    void Start()
    {
        GetComponent<Rigidbody>().maxAngularVelocity = 500000f;
        origem = GetComponent<Rigidbody>().position;
        m_MyAudioSource = GetComponent<AudioSource>();
    }

     void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Pista" && GetComponent<Rigidbody>().position.y > 0.36)
         {
             m_Play = true;
             if(m_MyAudioSource.clip != audio[2]){
                changed = true;
                m_MyAudioSource.clip = audio[2];
             }
         }
    }

    void OnCollisionEnter(Collision col)
     {
         
         if (col.gameObject.name == "Pista")
         {
             m_Play = true;
             if(m_MyAudioSource.clip != audio[0]){
                changed = true;
                m_MyAudioSource.clip = audio[0];
             }
         }
         if (col.gameObject.name == "Bouncer")
         {
             score = score + 100;
         }
         if (col.gameObject.name == "Returner")
         {
             score = score + 50;
         }
         if (col.gameObject.name == "Corkscrew")
         {
             score = score + 200;
         }
         if (col.gameObject.name == "muroAbaixo" || col.gameObject.name == "muroAbaixoVidro")
         {
             score = 0;
             GetComponent<Rigidbody>().velocity = Vector3.zero;
             GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
             GetComponent<Rigidbody>().position = origem;
             m_MyAudioSource.PlayOneShot(audio[3], 1);
         }
     }

     void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "Wallride" && GetComponent<Rigidbody>().position.y > 0.36)
         {
             score = score + 150;
             m_Play = true;
             if(m_MyAudioSource.clip != audio[1]){
                changed = true;
                m_MyAudioSource.clip = audio[1];
             }
         }
    }

    void Update()
    {
        if(Input.GetButton("Cancel")){
            score = 0;
             GetComponent<Rigidbody>().velocity = Vector3.zero;
             GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
             GetComponent<Rigidbody>().position = origem;
             m_MyAudioSource.PlayOneShot(audio[3], 1);
        }
        if(score > maxScore){
            maxScore = score;
        }
        if (GetComponent<Rigidbody>().position.y > 1)
         {
             score = score + 5;
         }

        if (m_Play == true && (!m_MyAudioSource.isPlaying || changed == true))
        {
            //Play the audio you attach to the AudioSource component
            m_MyAudioSource.Play();
            m_Play = false;
            changed = false;
        }
    }
}
