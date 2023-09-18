using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int score;
    public int life=3;
    public int level;
    public TextMeshProUGUI scores;
    public TextMeshProUGUI lifes;
    public bool gameoverd;
    public GameObject pannel;
    public int numberofbriks;
    public GameObject paneel;
    public GameObject pausebutton;
    // Start is called before the first frame update
    void Start()
    {

       
        lifes.text = life.ToString();
        scores.text = score.ToString();
        numberofbriks = numberofbriks = GameObject.FindGameObjectsWithTag("brike").Length;

        // Update is called once per frame
    }
    public void updatelifes(int updatedvalue)//updated value can be positive or negatives,when player gtes a nuw extralife updated value will bee positive,if player loosesa value it will decreases//
    {
        life += updatedvalue;
        if (life <= 0)
        {

          life = 0;//life 0 il thazhea pokathirikkkan
           
            gameover();
          

        }
       
       
       lifes.text = life.ToString(); 
    }
    public void scoreupdater(int updatedvalue)
    {
       
        score += updatedvalue;
        scores.text = score.ToString();
    }
    public void ubdatednumberofbriks()
    {
        numberofbriks--;
        if (numberofbriks <= 0)
        {
            pausebutton.SetActive(false);
            paneel.SetActive(true);
        }
    }
  public  void gameover()
    {
        gameoverd=true;

        pannel.SetActive(true);
    }
    public void RESTART()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     
    }
    public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //sceanmanager will load next intex sceana

    }
    public void quit()
    {
        Application.Quit();

    }
   
}
