/*
 * Created by: Andres Galiasso
 * Date created: 11.08.2021
 * 
 * Edited by: Andres Galiasso
 * Last edited: 11.08.2021
 * 
 * Description: Rotates object at a certain speed
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    /**** VARIABLES ****/
    public float rotationSpeed = 20f;

    private void FixedUpdate()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
