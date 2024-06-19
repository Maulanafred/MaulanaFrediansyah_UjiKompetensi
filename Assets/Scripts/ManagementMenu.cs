using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ManagementMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame(){
        SceneManager.LoadScene(1);
        AudioManager.instance.StopBGM(0);

    }

    public void ExitGame(){
        Application.Quit();
    }

    public void PlaySFXButton(){
        AudioManager.instance.PlaySFX(0);
    }
    


}
