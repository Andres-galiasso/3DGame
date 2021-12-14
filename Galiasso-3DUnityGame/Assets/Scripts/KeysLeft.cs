/*
 * Created by: Andres Galiasso
 * Date created: 12.10.2021
 * 
 * Edited by: Andres Galiasso
 * Last edited: 12.13.2021
 * 
 * Description: Says how many keys are left
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysLeft : MonoBehaviour
{
    /**** VARIABLES ****/
    private Text keyLeftText = null;
    private float totalKeys = 3f;

    private void Awake()
    {
        keyLeftText = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        keyLeftText.text = "Keys left: " + (totalKeys - CollectKey.keysCollected);
    }
}