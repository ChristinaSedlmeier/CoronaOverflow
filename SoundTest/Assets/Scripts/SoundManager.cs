using UnityEngine.Video;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;

public  class SoundManager : MonoBehaviour
{
    public AudioSource video1;
    public AudioSource video2;
    public AudioSource video3;
    public AudioSource video4;



    public void muteVideos()
    {

        //float currentTime = 0;
        //float start = video1.volume;
        //float duration = 1.0f;

        //while (currentTime < duration)
        //{
        //    currentTime += Time.deltaTime;
        //    video1.volume = Mathf.Lerp(start, 0.02f, currentTime / duration);
        //    video2.volume = Mathf.Lerp(start, 0.02f, currentTime / duration);
        //    video3.volume = Mathf.Lerp(start, 0.02f, currentTime / duration);
        //    video4.volume = Mathf.Lerp(start, 0.02f, currentTime / duration);

        //}

        StartCoroutine(UpdateFadeOut());

    }

    private IEnumerator UpdateFadeOut()
    {
        //float t = 0.0f;

        //for(t =0; t < 0.1f; t+= Time.deltaTime)
        //{
        //    Debug.Log(video1.volume);
        //    video1.volume = (1 - (t / 0.1f));
        //    video2.volume = (1 - (t / 0.1f));
        //    video3.volume = (1 - (t / 0.1f));
        //    video4.volume = (1 - (t / 0.1f));
        //    yield return null;
        //}
        float currentTime = 0;
        float start = video1.volume;
        float duration = 0.5f;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            video1.volume = Mathf.Lerp(start, 0.02f, currentTime / duration);
            video2.volume = Mathf.Lerp(start, 0.02f, currentTime / duration);
            video3.volume = Mathf.Lerp(start, 0.02f, currentTime / duration);
            video4.volume = Mathf.Lerp(start, 0.02f, currentTime / duration);
            yield return null;
        }
    }

    private IEnumerator UpdateFadeIn()
    {
        float currentTime = 0;
        float start = video1.volume;
        float duration = 0.4f;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            video1.volume = Mathf.Lerp(start, 1f, currentTime / duration);
            video2.volume = Mathf.Lerp(start, 1f, currentTime / duration);
            video3.volume = Mathf.Lerp(start, 1f, currentTime / duration);
            video4.volume = Mathf.Lerp(start, 1f, currentTime / duration);
            yield return null;
        }
    }




    public void unMuteVideos()
    {

        StartCoroutine(UpdateFadeIn());

    }
}
