/*
 * Created by: Andres Galiasso
 * Date created: 12.10.2021
 * 
 * Edited by: Andres Galiasso
 * Last edited: 12.13.2021
 * 
 * Description: Opens the door
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    /**** VARIABLES ****/
    public GameObject doorClosed = null;
    public GameObject doorOpen = null;
    private bool isDoorClosed = true;

    private void FixedUpdate()
    {
        if (isDoorClosed && CollectKey.keysCollected == 3)
        {
            DoorChange();
        }
    }

    private void DoorChange()
    {
        if (doorClosed != null && doorOpen != null)
        {
            doorClosed.SetActive(false);
            doorOpen.SetActive(true);
        }
    }
}
