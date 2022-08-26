using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zoo6 : MonoBehaviour
{
    public void LoadGame()
    {
        //load the game scene 
        SceneManager.LoadScene(7); //0 = Main Menu, 1 = Game Scene
    }
}
