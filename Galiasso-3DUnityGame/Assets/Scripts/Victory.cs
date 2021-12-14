/*
 * Created by: Andres Galiasso
 * Date created: 12.10.2021
 * 
 * Edited by: Andres Galiasso
 * Last edited: 12.13.2021
 * 
 * Description: Ends game when touching player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]

public class Victory : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
