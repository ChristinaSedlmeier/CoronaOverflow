using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayInterview : MonoBehaviour
{
    public AudioSource source; 

    void Start()
    {
        FindObjectOfType<SoundManager>().Play(source);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
