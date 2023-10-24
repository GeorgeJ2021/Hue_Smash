using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPan : MonoBehaviour
{
    Scene scene;
    public GameObject MainMenuPan,SelectLVL;
     void Awake()
    {
        scene = SceneManager.GetActiveScene();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(scene.name);
    }
    public void NextLvl()
    {
        int nextscene = scene.buildIndex +1;
        SceneManager.LoadScene(nextscene);
        Debug.Log("Next Scene");
    }
    public void MainMenu()
    {
        Debug.Log("Main Menu opened");
        SceneManager.LoadScene(0);
    }
    public void Play()
    {
      SceneManager.LoadScene(1);
    }
    public void Selectlvl()
    {
        //selection
        MainMenuPan.SetActive(false);
        SelectLVL.SetActive(true);
    }
    public void Goback()
    {
        MainMenuPan.SetActive(true);
        SelectLVL.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
