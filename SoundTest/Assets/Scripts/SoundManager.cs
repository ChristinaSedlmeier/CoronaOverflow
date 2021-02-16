using UnityEngine.Video;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using System;

public  class SoundManager : MonoBehaviour
{


    public Sound[] sounds;

    public AudioSource[] videos;

    void Awake ()
    {

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            //s.keyFrames = s.keyFrames;
            s.source.volume = s.volume;
        }
    }

    public void Play(string name) 
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound " + name + "not found");
            return;
        }

        s.source.Play();
    }


    public void PlayKey(string name, int frameNum)
    {
        Debug.Log(frameNum);
        Sound s = Array.Find(sounds, sound => sound.name == name);
        KeyFrame f = Array.Find(s.keyFrames, fr => fr.frame == frameNum);
        Debug.Log(f.sec);
        if (s == null)
        {
            Debug.LogWarning("Sound " + name + "not found");
            //yield return null;
        }
        Debug.Log(f.sec);
        StartCoroutine(PlayDelayed(f.sec, f.delay, s));

       
    }

    private IEnumerator PlayDelayed(float sec, float delay, Sound s)
    {
        yield return new WaitForSeconds(delay);
        s.source.time = sec;
        s.source.Play();
    }


    void Start ()
    {
        Play("Andrea_Interview");
        //Play("Erna_Interview");
        //Play("Georg_Interview");
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
