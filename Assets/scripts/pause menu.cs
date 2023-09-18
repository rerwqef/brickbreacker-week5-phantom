using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject resumemenu;
    public GameObject x;
    public GameManagerstandqt GameManagerstandqt;
    public GameObject mainmainnuchecking;
    public void checker2()
    {
       mainmainnuchecking.SetActive(true);
    }

    public void nochecker()
    {
        mainmainnuchecking.SetActive(false);
    }
    public void xw()
    {
        pause();
        x.SetActive(true);
    }

    public void contiue(){
       x.SetActive(false);
        resume();   
   }
    public void pause()
    {
        pauseMenu.SetActive(false);
        resumemenu.SetActive(true);
        Time.timeScale = 0f;//for pausing used
       

    }
    public void resume()
    {
        resumemenu.SetActive(false);
        pauseMenu.SetActive(true);
        Time .timeScale = 1f;//for restart
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
