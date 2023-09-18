using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerstandqt : MonoBehaviour
{
    public GameObject pannel;
    public GameObject paneel2;
    public GameObject paneel3;

    public void checker1()
    {
        paneel2.SetActive(true);
    }
    public void checker2() { 
        paneel3.SetActive(true);
    }
    
   public void nochecker()
    {
        paneel2.SetActive(false);
    }
    public  void nochecker2()
    {
        paneel3.SetActive(false);
    }



    public void quit()
    {
        Application.Quit();

    }
    public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //sceanmanager will load next intex sceana

    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
