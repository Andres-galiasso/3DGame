/*
 * Created by: Andres Galiasso
 * Date created: 12.09.2021
 * 
 * Edited by: Andres Galiasso
 * Last edited: 12.13.2021
 * 
 * Description: Increases counter of keys collected, deactivates keys
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class CollectKey : MonoBehaviour
{
    /**** VARIABLES ****/
    public static float keysCollected = 0f;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            keysCollected++;
            this.gameObject.SetActive(false);
        }
    }
}
