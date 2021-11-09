/*
 * Created by: Andres Galiasso
 * Date created: 11.08.2021
 * 
 * Edited by: Andres Galiasso
 * Last edited: 11.08.2021
 * 
 * Description: Makes light go BLINK BLINK BLINK and be scary
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]

public class LightBlinking : MonoBehaviour
{
    /**** VARIABLES ****/

    public float blinkTime = 0.2f;
    public float minWaitTime = 1f;
    public float maxWaitTime = 5f;
    private bool blinkAvailable = true;
    private float lightIntensity;

    private Light thisLight = null;

    private void Awake()
    {
        thisLight = GetComponent<Light>();
        lightIntensity = thisLight.intensity;
    }

    private void FixedUpdate()
    {
        if (blinkAvailable)
        {
            blinkAvailable = false;
            BlinkLight();
        }
    }

    private void BlinkLight()
    {
        float waitTime = Random.Range(minWaitTime, maxWaitTime);
        Invoke("LightOff", waitTime);
    }

    private void LightOff()
    {
        thisLight.intensity = 0f;
        Invoke("LightOn", blinkTime);
    }

    private void LightOn()
    {
        thisLight.intensity = lightIntensity;
        blinkAvailable = true;
    }
}
