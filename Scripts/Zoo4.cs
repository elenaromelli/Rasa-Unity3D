using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zoo4 : MonoBehaviour
{
    public void LoadGame()
    {
        //load the game scene 
        SceneManager.LoadScene(5); //0 = Main Menu, 1 = Game Scene
    }
}