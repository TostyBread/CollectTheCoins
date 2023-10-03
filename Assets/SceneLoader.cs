using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
        public void StartGame()//To Start Game
        {
            SceneManager.LoadScene("MainGame");
        }

    public void Return()//To Main Menu
    {
        SceneManager.LoadScene("MainMenu");
    }
}
