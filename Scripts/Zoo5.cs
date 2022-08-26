using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zoo5 : MonoBehaviour
{
    public void LoadGame()
    {
        //load the game scene 
        SceneManager.LoadScene(6); //0 = Main Menu, 1 = Game Scene
    }
}