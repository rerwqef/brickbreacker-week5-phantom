using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class buttonpress : MonoBehaviour
{

    public AudioSource audio;
    public AudioClip clip1;
    public void playbutton()
    {
        audio.clip = clip1;
      audio.Play();

    }
   



}
