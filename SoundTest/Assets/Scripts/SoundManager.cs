using UnityEngine.Video;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using System;

public  class SoundManager : MonoBehaviour
{


    public Sound[] sounds;
    public AudioSource[] interviews;
    public AudioSource[] videos;

    void Awake ()
    {

        //foreach(Sound s in sounds)
        //{
        //    s.source = gameObject.AddComponent<AudioSource>();
        //    s.source.clip = s.clip;

        //    s.source.volume = s.volume;
        //}
        foreach (AudioSource s in interviews)
        {
            //Debug.Log(s);
        }
    }

    public void Play(AudioSource source)
    {
        Debug.Log(source.clip);
        source.Stop();
        //Sound s = Array.Find(sounds, sound => sound.name == name);
        //if (s == null)
        //{
        //    Debug.LogWarning("Sound " + name + "not found");
        //    return;
        //}
        
        //s.source.Play();
    }



    void Start ()
    {
        //Play("Andrea");
        //Play("Erna_Interview");
    }

    public void muteVideos()
    {


        StartCoroutine(UpdateFadeOut());

    }

    private IEnumerator UpdateFadeOut()
    {

        float currentTime = 0;
        float start = videos[0].volume;
        float duration = 0.5f;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            foreach(AudioSource v in videos)
            {
                v.volume = Mathf.Lerp(start, 0.012f, currentTime / duration);
            }

            yield return null;
        }
    }

    private IEnumerator UpdateFadeIn()
    {
        float currentTime = 0;
        float start = videos[0].volume;
        float duration = 0.4f;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            foreach (AudioSource v in videos)
            {
                v.volume = Mathf.Lerp(start, 1f, currentTime / duration);
            }

            yield return null;
        }
    }




    public void unMuteVideos()
    {

        StartCoroutine(UpdateFadeIn());

    }
}
