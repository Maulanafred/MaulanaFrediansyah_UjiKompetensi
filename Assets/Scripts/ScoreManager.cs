using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    public TMP_Text timetext;

    public TMP_Text scoretext;

    public int score;

    public float time = 60;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
        time -= Time.deltaTime;
        timetext.text = time.ToString();
        
    }

    public void AddScore(int amount){
        score += amount;
    }
}
