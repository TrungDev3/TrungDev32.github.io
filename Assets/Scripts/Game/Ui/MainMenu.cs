using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using ThirdwebSDK;

public class MainMenu : MonoBehaviour
{
   // public int buildIndex = 0;
    public void PLayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }    

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }    

    public void WalletSence()
    {
        Debug.Log("Connect Wallet");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

    }

    public void BackMenu()
    {
        Debug.Log("Back Menu");
        SceneManager.LoadScene("Menu");
    }
}
