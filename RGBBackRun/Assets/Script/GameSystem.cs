using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void EndGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
            Application.OpenURL("https://tokivirtualreality.blogspot.com/");
        #else
            Application.Quit();
        #endif
    }

    public void ReternGame()
        {
            SceneManager.LoadScene("Title");
        }
}