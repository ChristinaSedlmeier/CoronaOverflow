using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour

{

    Material lightOn;
    Material lightOff;

    void Start()
    {
        lightOn = Resources.Load("Emission", typeof(Material)) as Material;
        lightOff = Resources.Load("LightOff", typeof(Material)) as Material;
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider);
        if (collider.tag == "Player")
        {
            GetComponent<Renderer>().material = lightOn;
            Debug.Log("is Player");
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            GetComponent<Renderer>().material = lightOff;
            Debug.Log("is Player");
        }
    }
}
