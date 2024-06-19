using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagementGame : MonoBehaviour
{

    public GameObject mainCamera;

    public GameObject gameOverCamera;

    public GameObject uiGame;

    public GameObject uiPause;

    public GameObject uiGameOver;


    private bool gameover = false;

    private bool pause ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && uiPause.activeSelf == false && gameover == false)
        {
            Pause();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && uiPause.activeSelf == true && gameover == false)
        {
            Resume();
        }


    

        if(ScoreManager.instance.time <= 0f)
        {
            GameOver();
        }
        
    }

    public void GameOver()
    {
        gameover = true;
        uiGame.SetActive(false);
        uiGameOver.SetActive(true);
        mainCamera.SetActive(false);
        gameOverCamera.SetActive(true);
        Time.timeScale = 0f;

        AudioManager.instance.PlaySFX(2);



    }

    public void Pause()
    {
        uiPause.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        uiPause.SetActive(false);
        Time.timeScale = 1f;
    

    }

    public void ButtonClicked(){
        AudioManager.instance.PlaySFX(3);
    }

    public void Replay(){
        
        SceneManager.LoadScene(1);

        StartCoroutine(ReplayThisGame());


    }


    public void Mainmenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
        AudioManager.instance.StopBGM(1);
        AudioManager.instance.PlayBGM(0);

    }

    IEnumerator ReplayThisGame(){
        yield return new WaitForSeconds(2f);
        Time.timeScale = 1f;
    }
}
