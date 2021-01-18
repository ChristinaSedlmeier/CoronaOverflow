using UnityEngine;
using UnityEngine.Video;
using UnityEngine.EventSystems;


public class LightController : MonoBehaviour

{

    //Material lightOn;
    //Material lightOff;
    public AudioSource myAudio;

    void Start()
    {
        //lightOn = Resources.Load("Emission", typeof(Material)) as Material;
        //lightOff = Resources.Load("LightOff", typeof(Material)) as Material;
        //myAudio = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider);
        if (collider.tag == "Player")
        {
            //GetComponent<Renderer>().material = lightOn;
            GameObject.Find("SoundManager").GetComponent<SoundManager>().muteVideos();
            Debug.Log("play Heartbeat");
            myAudio.Play();


        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            //GetComponent<Renderer>().material = lightOff;
            GameObject.Find("SoundManager").GetComponent<SoundManager>().unMuteVideos();
            myAudio.Stop();
        }
    }
}
