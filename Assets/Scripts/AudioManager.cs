using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    public AudioSource[] bgm;
    public AudioSource[] sfx;
    // Start is called before the first frame update
    void Start()
    {


        if(instance == null){
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        PlayBGM(0);
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBGM(int index){
        bgm[index].Play();
    }

    public void StopBGM(int index){
        bgm[index].Stop();
    }

    public void PlaySFX(int index)
    {
        sfx[index].Play();
    }


}
