/*
 * Created by: Andres Galiasso
 * Date created: 12.13.2021
 * 
 * Edited by: Andres Galiasso
 * Last edited: 12.13.2021
 * 
 * Description: Methods main menu buttons will call
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void StartButton(string loadlevel)
    {
        SceneManager.LoadScene(loadlevel);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
