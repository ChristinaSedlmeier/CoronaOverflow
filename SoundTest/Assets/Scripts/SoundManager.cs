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


        StartCoroutine(UpdateFadeOut());

    }

    private IEnumerator UpdateFadeOut()
    {

        float currentTime = 0;
        float start = video1.volume;
        float duration = 0.5f;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            video1.volume = Mathf.Lerp(start, 0.012f, currentTime / duration);
            video2.volume = Mathf.Lerp(start, 0.012f, currentTime / duration);
            video3.volume = Mathf.Lerp(start, 0.012f, currentTime / duration);
            video4.volume = Mathf.Lerp(start, 0.012f, currentTime / duration);
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
